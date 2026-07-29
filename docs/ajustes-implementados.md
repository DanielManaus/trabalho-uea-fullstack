# Ajustes implementados

## Infraestrutura

- Criado `backend/Dockerfile` com build e runtime separados para ASP.NET Core 8.
- Criado `frontend/Dockerfile` com build em Node 20 e publicacao em Nginx.
- Criado `docker-compose.yml` com servicos `backend` e `frontend`, portas, health checks e variaveis.
- Criado `.env.example` na raiz.

## Back-end

- Mantida a API ASP.NET Core com Swagger, endpoints REST e dados em memoria.
- Ajustado CORS para ler `FRONTEND_ORIGIN`, mantendo `http://localhost:5173` como padrao.

## Front-end

- Mantido consumo real da API por `VITE_API_URL`.
- Mantidos estados de carregamento, erro, sucesso, formularios e filtros existentes.

## Documentacao

- README raiz reescrito para orientar execucao e apresentacao.
- Criados documentos de arquitetura, contrato da API, evidencias de testes e roteiro de apresentacao.
- Criado workflow `.github/workflows/ci.yml` para validar build de backend, frontend e Docker.
