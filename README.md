Microsoft.EntityFrameworkCore.Tools.DotNet Paketi Nuget'den kurulma aşamasında hata vermektedir. 
Manuel olarak csproj dosyasında bulunan ItemGroup içine eklenmelidir.

<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1 />
