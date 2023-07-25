# Clean Architecture Essential 
Repositório com exemplos do curso CleanArchitectureEssential de Macoratti<br/><br/><br/>


Padrões Projeto<br/>

CleanArchMvc<br/><br/>
-> CleanArchMvc.Domain: Modelo de domínio, regrass de negócio e interfaces<br/>

-> CleanArchMvc.Application: Regras de domínio da aplicação, mapeamentos, serviços, DTOs, CQRS<br/>

-> CleanArchMvc.Infra.Data: EF Core, contexto, configurações, migrations, repository<br/>

-> CleanArchMvc.Infra.IoC: Dependency Injection, registro dos serviços, tempo de vida<br/>

-> CleanArchMvc.WebUI: MVC, Controllers, Views, Filtros, ViewModels<br/>

Dependencias<br/><br/>
-> CleanArchMvc.Domain: Não tem dependencia<br/>

-> CleanArchMvc.Application: Dependencia: Domain<br/>

-> CleanArchMvc.Infra.Data:  Dependencia: Domain<br/>

-> CleanArchMvc.Infra.IoC:  Dependencia: Domain, Aplication, Infra.data<br/>

-> CleanArchMvc.WebUI: Dependencia: Infra.IoC<br/>

![Alt text](image.png)
