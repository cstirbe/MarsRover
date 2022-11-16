git pull --ff-only

echo 'Adding private remote...'
git remote add private-origin https://github.com/umg/umpg-interview-private.git
$gitRepo = $(git rev-parse --abbrev-ref HEAD --)[0]

echo 'Moving branch: '  $gitRepo

git push -u private-origin $gitRepo --force
git remote rm private-origin

# echo 'Restoring remote to origin...'
git branch --set-upstream-to origin main

echo 'Removing branches...'
git checkout main
git pull --ff-only

# delete local branches
git branch | %{ $_.Trim() } | ?{ $_ -notmatch 'main' } | %{ git branch -D $_ }

# delete remote branches except 'main'
git branch -a | %{$_.trim()} | ?{$_ -notmatch 'main'} | %{$_.Replace("remotes/","")} | %{git branch -d -r $_ ; if($?){ git push origin $_.Replace("origin/",":refs/heads/")}}
