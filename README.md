# Observable Property Generator

Migrated from http://customfilegenerators.codeplex.com/SourceControl/latest

Author: Philip Wolfe http://www.philipwolfe.com/

## Project Description

This project includes Visual Studio Custom Tools that aid in development of Silverlight, Windows Phone, and WPF applications or any MVVM project for that matter. The custom tool creates properties from backing fields that have a specific attribute. The properties are then used in binding and raise their changed event.

Please see the Documentation page for more information.

## Installation

The simplest way to install is to download and run the MSI. The source code contains the Visual Studio Setup project and you can build the MSI if you so choose.

The MSI performs the following actions:

1. Creates the application folder in the x86 program files folder

2. Copies the necessary files

3. Registers the managed DLL in the registry (for Visual Studio 2010 to find the custom tool through COM)

4. Registers the custom tool with Visual Studio 2010

5. (optionally) Installs a Custom Item Template (code template) into Visual Studio Project Setup

You can reference the `[GenerateObservableProperty]` attribute class in one of two ways.

1. Add a reference to the installed assembly CustomFileGenerators.ObservablePropertyAttributes[.SL4].dll

2. Add the GenerateObservablePropertyAttribute.cs file to your project.

Note: The custom tool doesn't care what the namespace is or in what assembly the attribute is located. It is just looking for the string.

## Usage

New Classes:

  Select the item Observable Property Class from the Add New Item dialog in Visual Studio 2010. (If the item is not there, you will have to manually install the item template.) (C# only at this time.)

Existing Classes

  1. On the property page of the code file, set the Custom Tool property to ObsPropGen

  2. Add the `[GenerateObservableProperty]` attribute to the private fields of your ViewModel or Model class and the custom tool generates the public property when you save the file
