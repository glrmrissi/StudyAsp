# 🍋‍🟩 Projeto RESTful com C# Minimal API

Este projeto é uma API RESTful desenvolvida com **C# e .NET** utilizando a abordagem de **Minimal APIs**, introduzida no .NET 6+. Ele implementa as operações básicas de um CRUD de forma simples, leve e performática.

---

## 🔨 Tecnologias Utilizadas

- **.NET 6/7+** — Plataforma base do projeto.
- **C#** — Linguagem de programação.
- **Minimal API** — Abordagem leve para criação de endpoints no .NET.
- **Entity Framework Core** — Para persistência em banco de dados.
- **PostgreSQL** — Banco de dados relacional.

---

## 🛠️ Funcionalidades da API

- 🔍 Listagem de itens
- 📄 Detalhamento por ID
- ➕ Criação de itens (POST)
- ✏️ Atualização de itens (PUT/PATCH)
- ❌ Remoção de itens (DELETE)

---

## ⚙️ Como Executar Localmente

1. Clone o repositório:
   ```bash
   git clone https://github.com/glrmrissi/StudyAsp.git

2. Abrir no Visual Studio 2022
3. Ter o banco de dados PostgreSQL
5. Fazer toda a parte do EntityFramework
4. Conectar o banco de dados ao projeto
6. Por fim executar o projeto via Visual Studio

``` bash
  |   TrySql.sln
|
+---.github
|   \---workflows
\---TrySql
    |   appsettings.Development.json
    |   appsettings.json
    |   Program.cs
    |   TrySql.csproj
    |   TrySql.csproj.Backup.tmp
    |   TrySql.csproj.user
    |
    +---bin
    |   \---Debug
    |       \---net8.0
    |           |   appsettings.Development.json
    |           |   appsettings.json
    |           |   Azure.Core.dll
    |           |   Azure.Identity.dll
    |           |   EntityFramework.dll
    |           |   EntityFramework.SqlServer.dll
    |           |   Humanizer.dll
    |           |   Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.dll
    |           |   Microsoft.Bcl.AsyncInterfaces.dll
    |           |   Microsoft.Build.Locator.dll
    |           |   Microsoft.CodeAnalysis.CSharp.dll
    |           |   Microsoft.CodeAnalysis.CSharp.Workspaces.dll
    |           |   Microsoft.CodeAnalysis.dll
    |           |   Microsoft.CodeAnalysis.Workspaces.dll
    |           |   Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.dll
    |           |   Microsoft.CodeAnalysis.Workspaces.MSBuild.dll
    |           |   Microsoft.Data.SqlClient.dll
    |           |   Microsoft.EntityFrameworkCore.Abstractions.dll
    |           |   Microsoft.EntityFrameworkCore.Design.dll
    |           |   Microsoft.EntityFrameworkCore.dll
    |           |   Microsoft.EntityFrameworkCore.Relational.dll
    |           |   Microsoft.EntityFrameworkCore.SqlServer.dll
    |           |   Microsoft.Extensions.Caching.Abstractions.dll
    |           |   Microsoft.Extensions.Caching.Memory.dll
    |           |   Microsoft.Extensions.Configuration.Abstractions.dll
    |           |   Microsoft.Extensions.DependencyInjection.Abstractions.dll
    |           |   Microsoft.Extensions.DependencyInjection.dll
    |           |   Microsoft.Extensions.DependencyModel.dll
    |           |   Microsoft.Extensions.Logging.Abstractions.dll
    |           |   Microsoft.Extensions.Logging.dll
    |           |   Microsoft.Extensions.Options.dll
    |           |   Microsoft.Extensions.Primitives.dll
    |           |   Microsoft.Identity.Client.dll
    |           |   Microsoft.Identity.Client.Extensions.Msal.dll
    |           |   Microsoft.IdentityModel.Abstractions.dll
    |           |   Microsoft.IdentityModel.JsonWebTokens.dll
    |           |   Microsoft.IdentityModel.Logging.dll
    |           |   Microsoft.IdentityModel.Protocols.dll
    |           |   Microsoft.IdentityModel.Protocols.OpenIdConnect.dll
    |           |   Microsoft.IdentityModel.Tokens.dll
    |           |   Microsoft.SqlServer.Server.dll
    |           |   Microsoft.Win32.SystemEvents.dll
    |           |   Mono.TextTemplating.dll
    |           |   Npgsql.dll
    |           |   Npgsql.EntityFrameworkCore.PostgreSQL.dll
    |           |   System.ClientModel.dll
    |           |   System.CodeDom.dll
    |           |   System.Composition.AttributedModel.dll
    |           |   System.Composition.Convention.dll
    |           |   System.Composition.Hosting.dll
    |           |   System.Composition.Runtime.dll
    |           |   System.Composition.TypedParts.dll
    |           |   System.Configuration.ConfigurationManager.dll
    |           |   System.Data.SqlClient.dll
    |           |   System.Diagnostics.DiagnosticSource.dll
    |           |   System.Drawing.Common.dll
    |           |   System.Formats.Asn1.dll
    |           |   System.IdentityModel.Tokens.Jwt.dll
    |           |   System.IO.Pipelines.dll
    |           |   System.Memory.Data.dll
    |           |   System.Runtime.Caching.dll
    |           |   System.Security.Cryptography.ProtectedData.dll
    |           |   System.Security.Permissions.dll
    |           |   System.Text.Encodings.Web.dll
    |           |   System.Text.Json.dll
    |           |   System.Windows.Extensions.dll
    |           |   TrySql.deps.json
    |           |   TrySql.dll
    |           |   TrySql.exe
    |           |   TrySql.pdb
    |           |   TrySql.runtimeconfig.json
    |           |   TrySql.staticwebassets.endpoints.json
    |           |
    |           +---cs
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---de
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---es
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---fr
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---it
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---ja
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---ko
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---pl
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---pt-BR
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---ru
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---runtimes
    |           |   +---browser
    |           |   |   \---lib
    |           |   |       \---net8.0
    |           |   |               System.Text.Encodings.Web.dll
    |           |   |
    |           |   +---unix
    |           |   |   \---lib
    |           |   |       +---net6.0
    |           |   |       |       Microsoft.Data.SqlClient.dll
    |           |   |       |       System.Drawing.Common.dll
    |           |   |       |
    |           |   |       \---netcoreapp2.1
    |           |   |               System.Data.SqlClient.dll
    |           |   |
    |           |   +---win
    |           |   |   \---lib
    |           |   |       +---net6.0
    |           |   |       |       Microsoft.Data.SqlClient.dll
    |           |   |       |       Microsoft.Win32.SystemEvents.dll
    |           |   |       |       System.Drawing.Common.dll
    |           |   |       |       System.Runtime.Caching.dll
    |           |   |       |       System.Security.Cryptography.ProtectedData.dll
    |           |   |       |       System.Windows.Extensions.dll
    |           |   |       |
    |           |   |       \---netcoreapp2.1
    |           |   |               System.Data.SqlClient.dll
    |           |   |
    |           |   +---win-arm
    |           |   |   \---native
    |           |   |           Microsoft.Data.SqlClient.SNI.dll
    |           |   |
    |           |   +---win-arm64
    |           |   |   \---native
    |           |   |           Microsoft.Data.SqlClient.SNI.dll
    |           |   |           sni.dll
    |           |   |
    |           |   +---win-x64
    |           |   |   \---native
    |           |   |           Microsoft.Data.SqlClient.SNI.dll
    |           |   |           sni.dll
    |           |   |
    |           |   \---win-x86
    |           |       \---native
    |           |               Microsoft.Data.SqlClient.SNI.dll
    |           |               sni.dll
    |           |
    |           +---tr
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           +---zh-Hans
    |           |       Microsoft.CodeAnalysis.CSharp.resources.dll
    |           |       Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |           |       Microsoft.CodeAnalysis.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |           |       Microsoft.CodeAnalysis.Workspaces.resources.dll
    |           |
    |           \---zh-Hant
    |                   Microsoft.CodeAnalysis.CSharp.resources.dll
    |                   Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
    |                   Microsoft.CodeAnalysis.resources.dll
    |                   Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.resources.dll
    |                   Microsoft.CodeAnalysis.Workspaces.resources.dll
    |
    +---Context
    |       AppDbContext.cs
    |       AppDbContextFactory.cs
    |
    +---Migrations
    |       20250412185358_InitialCreation.cs
    |       20250412185358_InitialCreation.Designer.cs
    |       AppDbContextModelSnapshot.cs
    |
    +---Model
    |       Categoria.cs
    |       Produtos.cs
    |
    +---obj
    |   |   project.assets.json
    |   |   project.nuget.cache
    |   |   TrySql.csproj.EntityFrameworkCore.targets
    |   |   TrySql.csproj.nuget.dgspec.json
    |   |   TrySql.csproj.nuget.g.props
    |   |   TrySql.csproj.nuget.g.targets
    |   |
    |   \---Debug
    |       \---net8.0
    |           |   .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
    |           |   ApiEndpoints.json
    |           |   apphost.exe
    |           |   staticwebassets.build.endpoints.json
    |           |   staticwebassets.build.json
    |           |   staticwebassets.references.upToDateCheck.txt
    |           |   staticwebassets.removed.txt
    |           |   TrySql.AssemblyInfo.cs
    |           |   TrySql.AssemblyInfoInputs.cache
    |           |   TrySql.assets.cache
    |           |   TrySql.csproj.AssemblyReference.cache
    |           |   TrySql.csproj.BuildWithSkipAnalyzers
    |           |   TrySql.csproj.CoreCompileInputs.cache
    |           |   TrySql.csproj.FileListAbsolute.txt
    |           |   TrySql.csproj.Up2Date
    |           |   TrySql.dll
    |           |   TrySql.GeneratedMSBuildEditorConfig.editorconfig
    |           |   TrySql.genruntimeconfig.cache
    |           |   TrySql.GlobalUsings.g.cs
    |           |   TrySql.MvcApplicationPartsAssemblyInfo.cache
    |           |   TrySql.pdb
    |           |   TrySql.sourcelink.json
    |           |
    |           +---ref
    |           |       TrySql.dll
    |           |
    |           +---refint
    |           |       TrySql.dll
    |           |
    |           \---staticwebassets
    |                   msbuild.build.TrySql.props
    |                   msbuild.buildMultiTargeting.TrySql.props
    |                   msbuild.buildTransitive.TrySql.props
    |
    \---Properties
            launchSettings.json
