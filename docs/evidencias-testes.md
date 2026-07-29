# Evidencias e testes

Nesta pasta colocamos os prints e alguns arquivos JSON para mostrar que a aplicacao funcionou.

## Prints

- `docs/prints/dashboard-frontend.png.png`: dashboard carregando no front-end.
- `docs/prints/swagger-api.png`: Swagger com os endpoints da API.
- `docs/prints/frontend.png`: tela de projetos.
- `docs/prints/tarefas-frontend.png`: tela de tarefas.
- `docs/prints/equipe-frontend.png`: tela de equipe.
- `docs/prints/projeto-criado-frontend3.png`: projeto criado pelo formulario.
- `docs/prints/erro-projeto-duplicado.png`: erro ao tentar criar projeto repetido.
- `docs/prints/tarefa-criada-frontend.png`: tarefa criada pelo formulario.
- `docs/prints/filtro-tarefas.png`: filtro aplicado na tela de tarefas.
- `docs/prints/status-tarefa-alterado.png`: tarefa com status alterado.

## Evidencias da API

- `docs/evidencias-api/health-check.json`
- `docs/evidencias-api/dashboard.json`
- `docs/evidencias-api/projects.json`
- `docs/evidencias-api/tasks.json`
- `docs/evidencias-api/swagger-openapi.json`

## Evidencias do Docker

- `docs/evidencias-api/docker-compose-logs up.txt`
- `docs/evidencias-api/docker-compose-logs img.txt`

## Testes feitos

1. Abrimos o front-end em `http://localhost:5173`.
2. Abrimos o Swagger em `http://localhost:5200/swagger`.
3. Testamos o health check em `http://localhost:5200/health`.
4. Criamos um projeto pela tela.
5. Tentamos criar projeto repetido para ver o erro.
6. Criamos uma tarefa.
7. Usamos filtro na tela de tarefas.
8. Alteramos o status de uma tarefa.
9. Rodamos a aplicacao com Docker Compose e salvamos logs.

## Comandos usados

```bash
docker compose up --build
docker compose ps
docker compose logs backend frontend
```

Tambem foram acessadas as rotas:

```text
http://localhost:5173
http://localhost:5200/swagger
http://localhost:5200/health
```

## Problemas encontrados

- O projeto base nao tinha Dockerfiles nem Compose.
- A API precisava aceitar a origem do front-end no CORS.
- Foi necessario organizar os prints e logs para apresentar as evidencias.

## Correcoes feitas

- Criamos os Dockerfiles.
- Criamos o `docker-compose.yml`.
- Ajustamos CORS usando `FRONTEND_ORIGIN`.
- Atualizamos README e documentos em `docs`.
