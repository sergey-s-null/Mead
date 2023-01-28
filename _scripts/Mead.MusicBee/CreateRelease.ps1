$projectName = "Mead.MusicBee"

"Current location: $PWD"

$hasUncommittedChanges = [bool](git update-index --refresh)
if ($hasUncommittedChanges)
{
    Write-Error "Has uncommited changes. Stop execution."
    return
}

$currentBranch = git branch --show-current
if (-not$?)
{
    return
}

"Current branch: '$currentBranch'"
if ($currentBranch -ne "master")
{
    Write-Error "Current branch is not 'master'. Stop execution."
    return
}

[xml]$content = Get-Content -Path "./$projectName/$projectName.nuspec"
$version = $content.package.metadata.version
if ($version.GetType() -ne [string])
{
    Write-Error ".nuspec file has invalid state: version is not a string."
    return
}

$tagName = "release/$projectName/v$version"

$isTagAlreadyExists = [bool](git tag -l $tagName)
if (-not$isTagAlreadyExists)
{
    git tag $tagName
    Write-Output "Tag '$tagName' created."
}
else
{
    Write-Output "Tag '$tagName' already exists."
}

"Pushing tag '$tagName' to origin..."
git push origin $tagName --porcelain
if (-not$?)
{
    return
}

"Creating release with tag '$tagName'..."
gh release create $tagName --verify-tag
if ($?)
{
    Write-Output "Done successfully"
}