class ReleaseCreator
{
    [string]$projectName

    ReleaseCreator([string]$projectName)
    {
        $this.projectName = $projectName
    }

    Create()
    {
        Write-Host "Current location: $PWD"

        if ( $this.HasUncommittedChanges())
        {
            throw "Has uncommited changes."
        }

        $currentBranch = $this.GetCurrentBranch()
        Write-Host "Current branch: '$currentBranch'"
        if ($currentBranch -ne "master")
        {
            throw "Current branch is not 'master'."
        }

        $version = $this.GetVersion()
        Write-Host "Release version: $version"

        $tagName = $this.GetReleaseTagName($version)
        $this.CreateTagIfNotExists($tagName)
        $this.PushTag($tagName)

        $this.CreateRelease($tagName)

        Write-Host "Done successfully"
    }

    [bool]
    HasUncommittedChanges()
    {
        return [bool](git update-index --refresh)
    }

    [string]
    GetCurrentBranch()
    {
        $currentBranch = git branch --show-current
        if (-not$?)
        {
            throw "Could not get current branch."
        }

        return $currentBranch
    }

    [string]
    GetVersion()
    {
        [xml]$content = Get-Content -Path "./$($this.projectName)/$($this.projectName).nuspec"
        $version = $content.package.metadata.version
        if ($version.GetType() -ne [string])
        {
            throw ".nuspec file has invalid state: version is not a string."
        }

        return $version
    }

    [string]
    GetReleaseTagName([string]$version)
    {
        return "release/$($this.projectName)/v$version"
    }

    CreateTagIfNotExists([string]$tagName)
    {
        $isTagAlreadyExists = [bool](git tag -l $tagName)
        if (-not$isTagAlreadyExists)
        {
            git tag $tagName
            Write-Host "Tag '$tagName' created."
        }
        else
        {
            Write-Host "Tag '$tagName' already exists."
        }
    }

    PushTag([string]$tagName)
    {
        Write-Host "Pushing tag '$tagName' to origin..."
        git push origin $tagName --porcelain
        if (-not$?)
        {
            throw "Could not push tag '$tagName'."
        }
    }

    CreateRelease([string]$tagName)
    {
        Write-Host "Creating release with tag '$tagName'..."
        gh release create $tagName --verify-tag
        if (-not$?)
        {
            throw "Could not create GitHub release."
        }
    }
}