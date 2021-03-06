git config --global user.email "$($env:GitEmail)"
git config --global user.name "$($env:GitAuthor)"
git config --global credential.helper store

Add-Content "$env:USERPROFILE\.git-credentials" "https://$($env:GitUsername):$($env:GitPassword)@github.com`n"

git remote add github https://$($env:GitUsername)@github.com/itofinity/Itofinity-Appveyor-Refit.git
git tag "v$($env:appveyor_build_version)-ci" $($env:APPVEYOR_REPO_COMMIT)
git push github --tags --quiet
