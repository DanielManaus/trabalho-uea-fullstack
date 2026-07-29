# Arquitetura

Este projeto usa a aplicacao OrbitBoard, que veio como base para o trabalho do modulo 5.

A ideia da aplicacao e simples: controlar projetos, tarefas e pessoas da equipe. O front-end mostra as telas e o back-end guarda os dados em memoria.

## Partes do projeto

- Front-end: React com Vite.
- Back-end: API em ASP.NET Core 8.
- Dados: ficam em memoria, entao reiniciam quando a API reinicia.
- Docker: usado para subir front-end e back-end juntos.

## Como uma tela carrega dados

1. A pessoa abre o front-end em `http://localhost:5173`.
2. O front-end chama a API em `http://localhost:5200`.
3. A API retorna JSON.
4. A tela mostra os dados ou uma mensagem de erro.

Exemplo: na tela de tarefas, o React chama `GET /api/tasks` e monta o quadro com as tarefas por status.

## Portas usadas

- Front-end: `5173`
- API: `5200`
- Swagger: `http://localhost:5200/swagger`
- Health check: `http://localhost:5200/health`

## Observacao

Nao usamos banco real porque o foco do trabalho era a integracao full stack, Docker e comunicacao entre front-end e API.
