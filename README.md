Microsoft.EntityFrameworkCore.Tools.DotNet Paketi Nuget'den kurulma aşamasında hata vermektedir. 
Manuel olarak csproj dosyasında bulunan ItemGroup içine eklenmelidir.
Eklenecek Kod Blogu: <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1 />
