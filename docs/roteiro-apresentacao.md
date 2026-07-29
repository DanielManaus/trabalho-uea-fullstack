# Roteiro de apresentacao

Tempo esperado: cerca de 8 a 12 minutos.

## 1. Inicio

Falar o nome do projeto, OrbitBoard, e os integrantes:

- Daniel Oliveira da Silva
- Paulo Messias Martins Dourado
- Andre de Alencar Marques
- Adriano Brandao Mourao

Depois explicar que o objetivo foi rodar e entender uma aplicacao full stack com front-end, API e Docker.

## 2. Arquitetura

Explicar de forma curta:

- React/Vite no front-end.
- ASP.NET Core 8 no back-end.
- Dados em memoria.
- Docker Compose para subir tudo junto.

## 3. Mostrar a aplicacao

Abrir:

```text
http://localhost:5173
```

Mostrar:

- dashboard;
- tela de projetos;
- criacao de projeto;
- tela de tarefas;
- criacao de tarefa;
- filtro;
- alteracao de status;
- tela de equipe.

## 4. Mostrar a API

Abrir:

```text
http://localhost:5200/swagger
```

Mostrar pelo menos:

- `GET /health`
- `GET /api/dashboard`
- `GET /api/projects`
- `GET /api/tasks`

## 5. Docker

Explicar que foram criados:

- `backend/Dockerfile`
- `frontend/Dockerfile`
- `docker-compose.yml`

Comando principal:

```bash
docker compose up --build
```

## 6. Testes

Mostrar a pasta `docs/prints` e os logs em `docs/evidencias-api`.

Testes feitos:

- API respondendo.
- Swagger abrindo.
- Front-end carregando dados da API.
- Cadastro de projeto.
- Erro de projeto duplicado.
- Cadastro de tarefa.
- Filtro e mudanca de status.
- Logs do Docker Compose.

## 7. Dificuldades

Pontos para comentar:

- Entender as portas do front-end e back-end.
- Ajustar CORS.
- Entender a diferenca entre rodar local e rodar no Docker.
- Organizar as evidencias para a entrega.

## 8. Final

Fechar dizendo que o grupo conseguiu executar a aplicacao, testar a integracao e documentar os principais pontos pedidos no trabalho.
