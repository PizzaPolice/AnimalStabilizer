#!/bin/bash
FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.7.2-api/ dotnet build AnimalStabilizer.csproj /property:Configuration=Release

cp ./bin/Release/net4.7.2/AnimalStabilizer.dll ../Assemblies
