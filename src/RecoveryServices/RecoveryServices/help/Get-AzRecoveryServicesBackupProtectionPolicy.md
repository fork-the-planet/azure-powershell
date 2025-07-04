---
external help file: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Backup.dll-Help.xml
Module Name: Az.RecoveryServices
ms.assetid: 2E202D0D-076D-431D-9338-9A84ABC0B461
online version: https://learn.microsoft.com/powershell/module/az.recoveryservices/get-azrecoveryservicesbackupprotectionpolicy
schema: 2.0.0
---

# Get-AzRecoveryServicesBackupProtectionPolicy

## SYNOPSIS
Gets Backup protection policies for a vault.

## SYNTAX

### NoParamSet (Default)
```
Get-AzRecoveryServicesBackupProtectionPolicy [-IsArchiveSmartTieringEnabled <Boolean>] [-VaultId <String>]
 [-DefaultProfile <IAzureContextContainer>] [-PolicySubType <PSPolicyType>] [<CommonParameters>]
```

### PolicyNameParamSet
```
Get-AzRecoveryServicesBackupProtectionPolicy [-Name] <String> [-IsArchiveSmartTieringEnabled <Boolean>]
 [-VaultId <String>] [-DefaultProfile <IAzureContextContainer>] [-PolicySubType <PSPolicyType>]
 [<CommonParameters>]
```

### WorkloadParamSet
```
Get-AzRecoveryServicesBackupProtectionPolicy [-WorkloadType] <WorkloadType>
 [-IsArchiveSmartTieringEnabled <Boolean>] [-VaultId <String>] [-DefaultProfile <IAzureContextContainer>]
 [-PolicySubType <PSPolicyType>] [<CommonParameters>]
```

### WorkloadBackupManagementTypeParamSet
```
Get-AzRecoveryServicesBackupProtectionPolicy [-WorkloadType] <WorkloadType>
 [-BackupManagementType] <BackupManagementType> [-IsArchiveSmartTieringEnabled <Boolean>] [-VaultId <String>]
 [-DefaultProfile <IAzureContextContainer>] [-PolicySubType <PSPolicyType>] [<CommonParameters>]
```

## DESCRIPTION
The **Get-AzRecoveryServicesBackupProtectionPolicy** cmdlet gets Azure Backup protection policies for a vault.
Set the vault context by using the Set-AzRecoveryServicesVaultContext cmdlet before you use the current cmdlet.

## EXAMPLES

### Example 1: Get all policies in the vault
```powershell
Get-AzRecoveryServicesBackupProtectionPolicy
```

```output
Name                 WorkloadType       BackupManagementType BackupTime                DaysOfWeek   
----                 ------------       -------------------- ----------                ----------   
DefaultPolicy        AzureVM            AzureVM              4/14/2016 5:00:00 PM                   
NewPolicy            AzureVM            AzureVM              4/23/2016 5:30:00 PM                   
NewPolicy2           AzureVM            AzureVM              4/24/2016 1:30:00 AM
```

This command gets all protection policies created in the vault.

### Example 2: Get a specific policy
```powershell
$Pol= Get-AzRecoveryServicesBackupProtectionPolicy -Name "DefaultPolicy"
```

This command gets the protection policy named DefaultPolicy, and then stores it in the $pol variable.

### Example 3: Get only Enhanced policies in a vault
```powershell
$pol = Get-AzRecoveryServicesBackupProtectionPolicy -VaultId $vault.ID -BackupManagementType AzureVM -WorkloadType AzureVM  -PolicySubType Enhanced
```

This command gets only the Enhanced protection policies in RS vault, and then stores it in the $pol variable.

### Example 4: Get smart tiering enabled policies in a vault
```powershell
$pol = Get-AzRecoveryServicesBackupProtectionPolicy -VaultId $vault.ID -BackupManagementType AzureVM -WorkloadType AzureVM  -IsArchiveSmartTieringEnabled $true
```

This command gets only the policies in RS vault for which archive smart tiering is enabled. To fetch the policies for which smart tiering is disabled, set IsArchiveSmartTieringEnabled parameter to $false. To fetch all the policies, skip this parameter.

## PARAMETERS

### -BackupManagementType
The class of resources being protected. Currently the values supported for this cmdlet are AzureVM, AzureStorage, AzureWorkload

```yaml
Type: System.Nullable`1[Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models.BackupManagementType]
Parameter Sets: WorkloadBackupManagementTypeParamSet
Aliases:
Accepted values: AzureVM, SCDPM, AzureBackupServer, AzureStorage, AzureWorkload, MAB

Required: True
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsArchiveSmartTieringEnabled
Parameter to list policies for which smart tiering is Enabled/Disabled. Allowed values are $true, $false.

```yaml
Type: System.Nullable`1[System.Boolean]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name of the policy.

```yaml
Type: System.String
Parameter Sets: PolicyNameParamSet
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicySubType
Type of policy to be fetched: Standard, Enhanced

```yaml
Type: Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models.PSPolicyType
Parameter Sets: (All)
Aliases:
Accepted values: Standard, Enhanced

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VaultId
ARM ID of the Recovery Services Vault.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -WorkloadType
Workload type of the resource. The current supported values are AzureVM, AzureFiles, MSSQL

```yaml
Type: System.Nullable`1[Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models.WorkloadType]
Parameter Sets: WorkloadParamSet, WorkloadBackupManagementTypeParamSet
Aliases:
Accepted values: AzureVM, AzureSQLDatabase, AzureFiles, MSSQL

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models.PolicyBase

## NOTES

## RELATED LINKS

[New-AzRecoveryServicesBackupProtectionPolicy](./New-AzRecoveryServicesBackupProtectionPolicy.md)

[Remove-AzRecoveryServicesBackupProtectionPolicy](./Remove-AzRecoveryServicesBackupProtectionPolicy.md)

[Set-AzRecoveryServicesBackupProtectionPolicy](./Set-AzRecoveryServicesBackupProtectionPolicy.md)


