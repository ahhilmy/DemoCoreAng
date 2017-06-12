PM commands

Add-Migration Initial -Context AppDbContext
Update-Database -Context AppDbContext


For Identity...
add-migration Identity -Context UserDbContext
Update-Database -Context UserDbContext

...Updating production database in Azure
Update-Database -Context AppDbContext -Environment Production