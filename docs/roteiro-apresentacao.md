# Roteiro de apresentacao

Tempo sugerido: 8 a 12 minutos.

## 1. Abertura

Apresentar o nome OrbitBoard, os integrantes da equipe e o objetivo: demonstrar uma aplicacao full stack integrada com front-end, back-end, API documentada e Docker Compose.

## 2. Arquitetura

Explicar as camadas:

- Front-end React/Vite.
- Back-end ASP.NET Core 8.
- Dados em memoria.
- Docker Compose executando os dois servicos.

## 3. Demonstracao da aplicacao

1. Abrir `http://localhost:5173`.
2. Mostrar dashboard.
3. Criar ou editar projeto.
4. Criar tarefa.
5. Filtrar tarefas e alterar status.
6. Mostrar tratamento de erro com projeto duplicado ou exclusao bloqueada.

## 4. Demonstracao da API

1. Abrir `http://localhost:5200/swagger`.
2. Mostrar `GET /api/dashboard`.
3. Mostrar `GET /api/projects`.
4. Mostrar `POST /api/tasks` ou `PATCH /api/tasks/{id}/status`.
5. Abrir `http://localhost:5200/health`.

## 5. Docker e ambiente

Comentar:

- `backend/Dockerfile` publica a API .NET.
- `frontend/Dockerfile` gera build React e serve por Nginx.
- `docker-compose.yml` sobe os dois containers.
- Variaveis principais: `BACKEND_PORT`, `FRONTEND_PORT`, `FRONTEND_ORIGIN`, `VITE_API_URL`.

## 6. Testes e evidencias

Mostrar `docs/evidencias-testes.md`, prints coletados e logs dos containers.

## 7. Ajustes realizados

- Criacao de Dockerfiles.
- Criacao do Compose.
- CORS configuravel.
- Documentacao da arquitetura, contrato da API, testes e roteiro.
- CI simples no GitHub Actions para build de backend, frontend e imagens Docker.

## 8. Dificuldades

Explicar de forma objetiva:

- Entender a comunicacao entre portas do navegador e containers.
- Ajustar CORS para permitir a origem correta do front-end.
- Separar variaveis de ambiente de desenvolvimento local e Docker.

## 9. Fechamento

Informar contribuicao de cada integrante e reforcar que todos conhecem o fluxo da aplicacao, endpoints, Docker e evidencias.
