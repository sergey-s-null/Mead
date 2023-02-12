$availableProjects = `
    "Mead.MusicBee", `
    "Mead.MusicBee.Api", `
    "Mead.MusicBee.Api.Autofac.DependencyInjection", `
    "Mead.MusicBee.Remoting.Client"

$project = $args[0]
if (-not($availableProjects -CContains $project))
{
    throw "'$project' is invalid project."
}

Import-Module -Name ./_scripts/ReleaseCreator.ps1

$releaseCreator = [ReleaseCreator]::new($project)
$releaseCreator.Create()
