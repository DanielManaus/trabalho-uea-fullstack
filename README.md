# OrbitBoard - Trabalho Final Modulo 5

Aplicacao full stack didatica para gestao de projetos, tarefas e equipe. Este repositorio foi preparado para o Trabalho Final do Modulo 5 - Integracao Full Stack, com foco em front-end, back-end/API, Docker Compose, documentacao e evidencias de testes.

## Integrantes

| Nome | Contribuicao |
|---|---|
| Daniel Oliveira da Silva | Desenvolvimento, testes e apresentacao |
| Paulo Messias Martins Dourado | Documentacao, evidencias e apresentacao |
| André de Alencar Marques | Front-end, integracao e apresentacao |
| Adriano Brandão Mourão | Docker, API e apresentacao |

## Objetivo didatico

Demonstrar uma aplicacao com:

- front-end consumindo dados reais de uma API;
- back-end retornando JSON e documentado com Swagger;
- comunicacao HTTP entre React e ASP.NET Core;
- CORS, portas e variaveis de ambiente configuradas;
- execucao via Docker Compose;
- testes manuais e evidencias para apresentacao.

## Arquitetura resumida

| Camada | Tecnologia | Porta | Descricao |
|---|---|---:|---|
| Front-end | React 18, Vite, Nginx | 5173 | Telas de dashboard, projetos, tarefas e equipe. |
| Back-end/API | ASP.NET Core 8 | 5200 | Endpoints REST, Swagger, validacoes e erros padronizados. |
| Dados | Memoria | - | Projetos, tarefas e integrantes recriados ao reiniciar a API. |
| Infraestrutura | Docker Compose | - | Orquestra os containers de front-end e back-end. |

Fluxo principal: navegador -> front-end (`http://localhost:5173`) -> API (`http://localhost:5200`) -> dados em memoria.

Mais detalhes em [docs/arquitetura.md](docs/arquitetura.md).

## Tecnologias utilizadas

- React 18
- Vite
- React Router
- ASP.NET Core 8 Web API
- Swagger/OpenAPI
- Docker
- Docker Compose
- Nginx
- GitHub Actions

## Como executar com Docker Compose

Requisito: Docker Desktop instalado e em execucao.

```bash
docker compose up --build
```

Acessos:

| Recurso | URL |
|---|---|
| Front-end | `http://localhost:5173` |
| Back-end/API | `http://localhost:5200` |
| Swagger | `http://localhost:5200/swagger` |
| Health check | `http://localhost:5200/health` |

Para parar:

```bash
docker compose down
```

Para ver logs:

```bash
docker compose logs backend frontend
```

## Como executar localmente sem Docker

### Back-end

```bash
cd backend
dotnet restore OrbitBoard.Api.sln
dotnet run --project OrbitBoard.Api
```

API: `http://localhost:5200`

### Front-end

Em outro terminal:

```bash
cd frontend
npm install
npm run dev
```

Front-end: `http://localhost:5173`

## Variaveis de ambiente

Copie `.env.example` para `.env` se precisar alterar portas ou URLs.

| Variavel | Padrao | Uso |
|---|---|---|
| `BACKEND_PORT` | `5200` | Porta publicada da API no Docker. |
| `FRONTEND_PORT` | `5173` | Porta publicada do front-end no Docker. |
| `FRONTEND_ORIGIN` | `http://localhost:5173` | Origem permitida no CORS da API. |
| `VITE_API_URL` | `http://localhost:5200` | URL da API usada pelo front-end. |

## Endpoints principais

| Metodo | Endpoint | Descricao |
|---|---|---|
| GET | `/health` | Verifica saude da API. |
| GET | `/api/dashboard` | Retorna metricas e tarefas recentes. |
| GET | `/api/projects` | Lista projetos. |
| POST | `/api/projects` | Cria projeto. |
| PUT | `/api/projects/{id}` | Atualiza projeto. |
| DELETE | `/api/projects/{id}` | Exclui projeto sem tarefas. |
| GET | `/api/tasks` | Lista tarefas com filtros. |
| POST | `/api/tasks` | Cria tarefa. |
| PUT | `/api/tasks/{id}` | Atualiza tarefa. |
| PATCH | `/api/tasks/{id}/status` | Altera status da tarefa. |
| DELETE | `/api/tasks/{id}` | Exclui tarefa. |
| GET | `/api/team-members` | Lista integrantes. |

Contrato completo em [docs/contrato-api.md](docs/contrato-api.md).

## Testes e evidencias

Roteiro em [docs/evidencias-testes.md](docs/evidencias-testes.md).

Testes manuais recomendados:

1. Subir a aplicacao com `docker compose up --build`.
2. Acessar o health check da API.
3. Abrir Swagger e testar um endpoint.
4. Abrir o front-end e conferir dashboard.
5. Criar projeto.
6. Criar tarefa.
7. Filtrar e alterar status de tarefa.
8. Forcar um erro, como criar projeto duplicado.
9. Registrar prints e logs dos containers.

## Ajustes realizados

- Dockerfile do back-end.
- Dockerfile do front-end.
- `docker-compose.yml` com health checks.
- `.env.example` na raiz.
- CORS configuravel por `FRONTEND_ORIGIN`.
- Documentacao em `docs/`.
- Workflow simples de CI no GitHub Actions.

Detalhes em [docs/ajustes-implementados.md](docs/ajustes-implementados.md).

## Estrutura do repositorio

```text
orbit-board-project/
├── backend/
├── frontend/
├── docs/
├── .github/workflows/ci.yml
├── .env.example
├── .gitignore
├── docker-compose.yml
└── README.md
```

## Roteiro de apresentacao

O roteiro sugerido esta em [docs/roteiro-apresentacao.md](docs/roteiro-apresentacao.md) e cobre arquitetura, integracao, API, Docker, testes, ajustes e dificuldades.
