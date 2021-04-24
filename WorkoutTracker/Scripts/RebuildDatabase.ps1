Param(
   [string] $Server = "mssql.cs.ksu.edu",
   [string] $Database = "zachterrell57"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Schemas\Project.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.DailyMetrics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Location.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Weather.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Enivornment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Session.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.MuscleGroup.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Exercise.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.ExerciseMuscleGroup.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Tables\Project.Workout.sql"

##Write-Host "Stored procedures..."
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.CreatePerson.sql"
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.RetrievePersons.sql"
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.FetchPerson.sql"
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.GetPersonByEmail.sql"
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.SavePersonAddress.sql"
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"

##Write-Host "Inserting data..."
##Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WorkoutTracker\Sql\Data\Person.AddressType.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
