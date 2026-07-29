# Contrato da API

URL base local:

```text
http://localhost:5200
```

Swagger:

```text
http://localhost:5200/swagger
```

## Endpoints principais

### Health

- `GET /health`
- Usado para ver se a API esta rodando.

### Dashboard

- `GET /api/dashboard`
- Retorna os totais de projetos, tarefas, concluidas e atrasadas.

### Projetos

- `GET /api/projects`
- `GET /api/projects/{id}`
- `POST /api/projects`
- `PUT /api/projects/{id}`
- `DELETE /api/projects/{id}`

No front-end usamos esses endpoints para listar, criar, editar e excluir projetos.

Exemplo de projeto:

```json
{
  "name": "Projeto UEA Teste",
  "description": "Projeto usado para testar a integracao full stack.",
  "status": "Active"
}
```

### Tarefas

- `GET /api/tasks`
- `GET /api/tasks/{id}`
- `POST /api/tasks`
- `PUT /api/tasks/{id}`
- `PATCH /api/tasks/{id}/status`
- `DELETE /api/tasks/{id}`

A listagem de tarefas aceita filtros como:

```text
projectId, status, priority, assigneeId, search
```

Exemplo para alterar status:

```json
{
  "status": "Done"
}
```

### Equipe

- `GET /api/team-members`
- Retorna os membros cadastrados na memoria da API.

## Erros

A API retorna erro em JSON. No front-end testamos, por exemplo, criar um projeto com nome repetido. Nesse caso aparece uma mensagem avisando que ja existe projeto com esse nome.
