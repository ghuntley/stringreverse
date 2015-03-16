$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\src\StringReverse\bin\Release\StringReverse.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\StringReverse.nuspec)
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\StringReverse.compiled.nuspec

& $root\NuGet\NuGet.exe pack $root\nuget\StringReverse.compiled.nuspec -Symbols
