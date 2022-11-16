
$name = Read-Host 'Candidate name:'
$startDate = (Get-Date -Format o | ForEach-Object { $_ -replace ":", "." }).ToString()

Echo $startDate

if(!$name) { 
	Echo 'Candidate Name is mandatory, process will exit...'
	break
}
 git checkout main
 $name = $name -replace " ", "_"
 $branchName = $startDate + '__' + $name
 git checkout -b $branchName
 git push -u origin $branchName