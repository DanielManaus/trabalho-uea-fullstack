# Ajustes implementados

Esses foram os principais ajustes feitos em cima do projeto base.

## Docker

- Criamos o Dockerfile do back-end.
- Criamos o Dockerfile do front-end.
- Criamos o `docker-compose.yml`.
- Criamos o `.env.example`.

Com isso a aplicacao pode subir com:

```bash
docker compose up --build
```

## Back-end

- Mantivemos a API em ASP.NET Core 8.
- Conferimos Swagger e health check.
- Ajustamos o CORS para aceitar a origem do front-end pela variavel `FRONTEND_ORIGIN`.

## Front-end

- Mantivemos o React consumindo a API pela variavel `VITE_API_URL`.
- Testamos dashboard, projetos, tarefas, filtros e mensagens de erro.

## Documentacao

- Atualizamos o README.
- Criamos documentos simples dentro da pasta `docs`.
- Salvamos prints e logs usados como evidencia.

## CI

Tambem foi criado um workflow simples no GitHub Actions para validar build do back-end, front-end e Docker.
