# embedded-font
Embedded font in globals
Customize Font in Local resource by embedded

[![shandy](https://drive.google.com/file/d/1PRNu7MkcWOdK1r5enShVm-9e2fWXbBRH/view?usp=sharing)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

# Add the font file (otf or ttf) to your shared project and mark it as embedded resource
# Add Font to Assembly project  (AssemblyInfo.cs):
```
[assembly: ExportFont("UTM Avo.ttf", Alias = "UTM Avo")]
```
# Using in global
Resource App.xaml
```
<Style TargetType="Label">
<Setter Property="FontFamily" Value="UTM Avo"></Setter>
</Style>
```
# References:
https://devblogs.microsoft.com/xamarin/embedded-fonts-xamarin-forms/
