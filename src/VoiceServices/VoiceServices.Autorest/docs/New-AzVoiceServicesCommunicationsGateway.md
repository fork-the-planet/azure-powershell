---
external help file:
Module Name: Az.VoiceServices
online version: https://learn.microsoft.com/powershell/module/az.voiceservices/new-azvoiceservicescommunicationsgateway
schema: 2.0.0
---

# New-AzVoiceServicesCommunicationsGateway

## SYNOPSIS
Create a CommunicationsGateway

## SYNTAX

```
New-AzVoiceServicesCommunicationsGateway -Name <String> -ResourceGroupName <String> -Location <String>
 [-SubscriptionId <String>] [-ApiBridge <Hashtable>] [-Codec <TeamsCodecs[]>]
 [-DomainNameLabelScope <AutoGeneratedDomainNameLabelScope>] [-E911Type <E911Type>]
 [-EmergencyDialString <String[]>] [-OnPremMcpEnabled] [-Platform <CommunicationsPlatform[]>]
 [-ServiceLocation <IServiceRegionProperties[]>] [-Tag <Hashtable>] [-TeamsVoicemailPilotNumber <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a CommunicationsGateway

## EXAMPLES

### Example 1: Create a communications gateway
```powershell
$region = @()
$region += New-AzVoiceServicesCommunicationsGatewayServiceRegionObject -Name useast -PrimaryRegionOperatorAddress '198.51.100.1'
$region += New-AzVoiceServicesCommunicationsGatewayServiceRegionObject -Name useast2 -PrimaryRegionOperatorAddress '198.51.100.2'

New-AzVoiceServicesCommunicationsGateway -ResourceGroupName 'vtest-communication-rg' -Name vsc-gateway-pwsh01 -Location 'westcentralus' -Codec 'PCMA' -E911Type 'Standard' -Platform 'OperatorConnect' -ServiceLocation $region
```

```output
Location      Name               SystemDataCreatedAt  SystemDataCreatedBy  SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModifiedBy SystemDataLastModifiedByType ResourceGroupName      RetryAfter
--------      ----               -------------------  -------------------  ----------------------- ------------------------ ------------------------ ---------------------------- -----------------      ----------
westcentralus vsc-gateway-pwsh01 12/7/2022 7:09:45 AM v-diya@microsoft.com User                    12/7/2022 7:09:45 AM     v-diya@microsoft.com     User                         vtest-communication-rg 
```

Create a communications gateway.

## PARAMETERS

### -ApiBridge
Details of API bridge functionality, if required

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Codec
Voice codecs to support

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.TeamsCodecs[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainNameLabelScope
The scope at which the auto-generated domain name can be re-used

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.AutoGeneratedDomainNameLabelScope
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -E911Type
How to handle 911 calls

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmergencyDialString
A list of dial strings used for emergency calling.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Unique identifier for this deployment

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremMcpEnabled
Whether an on-premises Mobile Control Point is in use.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
What platforms to support

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.CommunicationsPlatform[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocation
The regions in which to deploy the resources needed for Teams Calling
To construct, see NOTES section for SERVICELOCATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20230131.IServiceRegionProperties[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsVoicemailPilotNumber
This number is used in Teams Phone Mobile scenarios for access to the voicemail IVR from the native dialer.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.Api20230131.ICommunicationsGateway

## NOTES

## RELATED LINKS

