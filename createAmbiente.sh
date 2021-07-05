#!/bin/bash

#Variaveis

Project_Name=${PWD##*/}

#Nome das camadas 
layer_0="0-Presentation"
layer_1="1-Services"
layer_2="2-Application"
layer_3="3-Domain"
layer_4="4-Infra"
layer_4_1="4.1-Data"
layer_4_2="4.2-CrossCutting"

#Nome dos Sub-Projetos
project_presentation=${Project_Name}".MVC"
project_application=${Project_Name}".Application"
project_domain=${Project_Name}".Domain"
project_data=${Project_Name}".Infra.Data"

#Nome das pastas dos sub-Projetos
entities="Entities"
interfaces="Interfaces"
services="Services"
contexto="Contexto"
repositories="Repositories"
entity_config="EntityConfig"

#Criando solucao
echo "Criando o sln ${Project_Name}"
dotnet new sln -o ${Project_Name}
cd ${Project_Name}
echo "Concluido"

#Criando pastas necessarias
echo "Criando Pastas"
mkdir ${layer_0} ${layer_1} ${layer_2} ${layer_3} ${layer_4}
cd ${layer_4}
mkdir ${layer_4_1} ${layer_4_2} 
cd ..
echo "Concluido"

#Criando camadas

echo "Criando camada ${layer_0}"
cd ${layer_0}
dotnet new mvc -o ${project_presentation}
cd ../
dotnet sln ${Project_Name}.sln add ./${layer_0}/${project_presentation}
echo "Concluido"

echo "Criando camada ${layer_2}"
cd ${layer_2}
dotnet new classlib -lang C# -o ${project_application}
cd ${project_application}
rm Class1.cs
mkdir mapper
dotnet add package AutoMapper
mkdir DTO
cd ../../
dotnet sln ${Project_Name}.sln add ./${layer_2}/${project_application}
echo "Concluido"

echo "Criando camada ${layer_3}"
cd ${layer_3}
dotnet new classlib -lang C# -o ${project_domain}
cd ${project_domain}
rm Class1.cs
mkdir ${entities} ${interfaces} ${services}
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.7
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add reference ../../${layer_2}/${project_application}/${project_application}.csproj
cd ../../
dotnet sln ${Project_Name}.sln add ./${layer_3}/${project_domain}
echo "Concluido"

echo "Criando camada ${layer_4}/${layer_4_1}"
cd ${layer_4}/${layer_4_1}
dotnet new classlib -lang C# -o ${project_data}
cd ${project_data}
dotnet add reference ../../../${layer_3}/${project_domain}/${project_domain}.csproj
rm Class1.cs
mkdir ${contexto} ${repositories} ${entity_config}
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.7
dotnet add package Microsoft.EntityFrameworkCore.Design
cd ../../../
dotnet sln ${Project_Name}.sln add ./${layer_4}/${layer_4_1}/${project_data}
echo "Concluido"

#Referencias externas
