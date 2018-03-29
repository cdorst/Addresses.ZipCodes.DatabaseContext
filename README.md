# Addresses.ZipCodes.DatabaseContext

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-zipcodes-databasecontext.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-zipcodes-databasecontext)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.ZipCodes.DatabaseContext.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.ZipCodes.DatabaseContext)

## Description

EntityFrameworkCore database context for ZipCode entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Addresses.ZipCodes](https://github.com/CDorst/Addresses.ZipCodes) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-zipcodes.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-zipcodes) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.ZipCodes.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.ZipCodes)
[CDorst.Addresses.States.DatabaseContext](https://github.com/CDorst/Addresses.States.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-states-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-states-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.States.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.States.DatabaseContext)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[Addresses.ZipCodes.ApiController](https://github.com/CDorst/Addresses.ZipCodes.ApiController) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-zipcodes-apicontroller.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-zipcodes-apicontroller) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.ZipCodes.ApiController.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.ZipCodes.ApiController)
[Addresses.StreetAddressLines.DatabaseContext](https://github.com/CDorst/Addresses.StreetAddressLines.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-streetaddresslines-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-streetaddresslines-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StreetAddressLines.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StreetAddressLines.DatabaseContext)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.ZipCodes.DatabaseContext](https://www.nuget.org/packages/CDorst.Addresses.ZipCodes.DatabaseContext)

## Version

1.0.0

## Metaproject

Addresses.ZipCodes.DatabaseContext is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

