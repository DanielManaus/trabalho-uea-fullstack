# Contrato da API

Base local: `http://localhost:5200`

Swagger: `http://localhost:5200/swagger`

Health check: `GET /health`

## Dashboard

| Metodo | Endpoint | Descricao |
|---|---|---|
| GET | `/api/dashboard` | Retorna metricas gerais e tarefas recentes. |

## Projetos

| Metodo | Endpoint | Descricao |
|---|---|---|
| GET | `/api/projects` | Lista projetos. |
| GET | `/api/projects/{id}` | Busca projeto por id. |
| POST | `/api/projects` | Cria projeto. |
| PUT | `/api/projects/{id}` | Atualiza projeto. |
| DELETE | `/api/projects/{id}` | Remove projeto sem tarefas vinculadas. |

Exemplo de criacao:

```json
{
  "name": "Projeto final Modulo 5",
  "description": "Organizacao da entrega full stack",
  "status": "Active",
  "startDate": "2026-07-20",
  "endDate": "2026-07-29"
}
```

## Tarefas

| Metodo | Endpoint | Descricao |
|---|---|---|
| GET | `/api/tasks` | Lista tarefas e aceita filtros. |
| GET | `/api/tasks/{id}` | Busca tarefa por id. |
| POST | `/api/tasks` | Cria tarefa. |
| PUT | `/api/tasks/{id}` | Atualiza tarefa. |
| PATCH | `/api/tasks/{id}/status` | Altera somente o status. |
| DELETE | `/api/tasks/{id}` | Remove tarefa. |

Filtros em `GET /api/tasks`: `projectId`, `status`, `priority`, `assigneeId`, `search`.

Exemplo de alteracao de status:

```json
{
  "status": "Done"
}
```

## Equipe

| Metodo | Endpoint | Descricao |
|---|---|---|
| GET | `/api/team-members` | Lista integrantes cadastrados em memoria. |

## Padrao de erros

A API usa respostas JSON com `ProblemDetails` para erros de validacao, conflitos, itens nao encontrados e falhas inesperadas. O front-end le `detail` ou `title` e exibe a mensagem para o usuario.
