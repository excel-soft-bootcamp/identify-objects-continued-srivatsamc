# Validation Controls
### All the validation controls in ASP.Net inherit the properties and methods of the BaseValidator class. 
- The important properties and methods of the BaseValidator class are:
   1. **ControlToValidate** – It indicates the input control to validate. It must be a unique value throughout the form. 
   2. **Enabled** – It enables or disables the validator.
   3. **Text** – It holds the message to be displayed in the event of a validation failure.
   4. **ErrorMessage** – The value in this attribute is displayed either when ValidationSummary control is used or when Text property is missing.
   5. **IsValid** – A Boolean attribute which indicates whether the control is valid or not.
   6. **Validate( )** – This method revalidates the control and updates the IsValid.

# Types of ASP.Net Validation Control

## 1.  RequiredFieldValidator
   This is an elementary validation control. Almost all the forms have some fields that are mandatory to be filled up by the user before proceeding forward. The Required Field Validator ensures that such fields are not left empty.

### Syntax :    
   <asp:RequiredFieldValidator ID="someUniqueId" runat="server" ControlToValidate ="someUniqueControlId" ErrorMessage="ErrorToDisplayOnValidationFailure"    InitialValue="aPlaceholderValue"> 
   </asp:RequiredFieldValidator> 

 ## 2.  RangeValidator
   The RangeValidator control simply specifies the permitted range within which the input value should fall. This is most helpful for numeral input values such as age or for Date input values.

### Syntax :   
   <asp:RangeValidator ID="some unique id" runat="server" ControlToValidate ="someUniqueControlId"
   ErrorMessage="ErrorToDisplayOnValidationFailure" Type="Integer" MinimumValue="0” MaximumValue="100”>
   </asp:RangeValidator>

 ## 3.  RegularExpressionValidator
   RegularExpressions, or simply Regex, are patterns that define the format of the text. If the text is in the same format, Regex returns true, else false. 

### Syntax :    
   <asp:RegularExpressionValidator ID="someUniqueId"runat="server" ControlToValidate ="someUniqueControlId" ErrorMessage="ErrorToDisplayOnValidationFailure" ValidationExpression="aRegexPattern”>
    </asp:RegularExpressionValidator>

## 4.  CompareValidator
   The CompareValidator control compares the value of one control with either a fixed value or a value in another control.

### Syntax :    
   <asp:CompareValidator ID="someUniqueId" runat="server" ControlToValidate ="someUniqueControlId"
   ErrorMessage="ErrorToDisplayOnValidationFailure" Type="string" ControlToCompare"ControlToValidateIdOfAnotherControl”
   ValueToCompare="aFixedValue” Operator="Equal”>
   </asp:CompareValidator>

## 5.  CustomValidator
   The custom validation code is written in a function in the code-behind page and the function name is passed as an attribute to the CustomValidator class. Custom validation can be done either at the client-side or the server-side.

### Syntax :    
   <asp:CustomValidator ID="someUniqueId" runat="server" ControlToValidate ="someUniqueControlId"
   ErrorMessage="ErrorToDisplayOnValidationFailure" ClientValidationFunction="functionName”>
   </asp:CustomValidator>    

## 6.  ValidationSummary
   The ValidationSummary control does not perform any validation. Its purpose is to display a summary of all the errors on the page.

### Syntax :    
   <asp:ValidationSummary ID="ValidationSummaryControl" runat="server" DisplayMode="BulletList” ShowSummary="true”HeaderText="List of Errors” />    


# UserControls
### A UserControl is a separate, reusable part of a page.It's just like a regular page, with an optional CodeBehind file. 
