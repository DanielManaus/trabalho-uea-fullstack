# Evidencias e testes manuais

Use este roteiro para registrar prints antes da apresentacao. As primeiras evidencias ja foram salvas em `docs/prints/` e `docs/evidencias-api/`.

## Evidencias geradas

| Evidencia | Arquivo |
|---|---|
| Dashboard do front-end | `docs/prints/dashboard-frontend.png.png` |
| Swagger da API | `docs/prints/swagger-api.png` |
| Tela de projetos | `docs/prints/frontend.png` |
| Tela de tarefas | `docs/prints/tarefas-frontend.png` |
| Tela de equipe | `docs/prints/equipe-frontend.png` |
| Projeto criado pelo front-end | `docs/prints/projeto-criado-frontend3.png` |
| Erro de projeto duplicado tratado no front-end | `docs/prints/erro-projeto-duplicado.png` |
| Tarefa criada pelo front-end | `docs/prints/tarefa-criada-frontend.png` |
| Filtro de tarefas aplicado | `docs/prints/filtro-tarefas.png` |
| Status de tarefa alterado | `docs/prints/status-tarefa-alterado.png` |
| Health check da API em JSON | `docs/evidencias-api/health-check.json` |
| Dashboard da API em JSON | `docs/evidencias-api/dashboard.json` |
| Projetos da API em JSON | `docs/evidencias-api/projects.json` |
| Tarefas da API em JSON | `docs/evidencias-api/tasks.json` |
| Contrato OpenAPI/Swagger em JSON | `docs/evidencias-api/swagger-openapi.json` |
| Logs do Docker Compose | `docs/evidencias-api/docker-compose-logs up.txt` |
| Imagens/containers Docker | `docs/evidencias-api/docker-compose-logs img.txt` |

## Testes realizados

| Cenario | Passos | Resultado esperado | Evidencia |
|---|---|---|---|
| Health check da API | Acessar `http://localhost:5200/health` | JSON com `status: healthy` | `docs/evidencias-api/health-check.json` |
| Swagger | Acessar `http://localhost:5200/swagger` | Tela Swagger com endpoints | `docs/prints/swagger-api.png` |
| Dashboard | Abrir `http://localhost:5173` | Cards e tarefas carregados | `docs/prints/dashboard-frontend.png.png` |
| Criar projeto | Enviar formulario de projeto valido | Projeto aparece na lista | `docs/prints/projeto-criado-frontend3.png` |
| Erro de conflito | Criar projeto com nome repetido | Mensagem de erro `409` exibida | `docs/prints/erro-projeto-duplicado.png` |
| Criar tarefa | Enviar tarefa vinculada a um projeto | Tarefa aparece no quadro | `docs/prints/tarefa-criada-frontend.png` |
| Filtros | Filtrar por status, prioridade ou texto | Lista muda conforme filtro | `docs/prints/filtro-tarefas.png` |
| Alterar status | Mover/alterar status de uma tarefa | Status atualizado na API e tela | `docs/prints/status-tarefa-alterado.png` |
| Logs dos containers | Rodar `docker compose logs backend frontend` | Logs sem erro critico | `docs/evidencias-api/docker-compose-logs up.txt` |

## Comandos usados

```bash
docker compose up --build
curl http://localhost:5200/health
curl http://localhost:5200/api/dashboard
docker compose ps
docker compose logs backend frontend
```

Quando o Docker Desktop estiver instalado, gere a evidencia final de containers com:

```bash
docker compose up --build
docker compose ps
docker compose logs backend frontend > docs/evidencias-api/docker-compose-logs.txt
```

## Problemas encontrados e correcoes

| Problema | Causa | Correcao |
|---|---|---|
| Falta de Dockerfiles e Compose | Projeto-base focava na aplicacao, nao na entrega conteinerizada | Criados `backend/Dockerfile`, `frontend/Dockerfile` e `docker-compose.yml`. |
| CORS fixo para uma origem | A API aceitava somente `http://localhost:5173` no codigo | Origem passou a ser configuravel por `FRONTEND_ORIGIN`. |
| Documentacao de entrega incompleta | README inicial orientava apenas criacao do repositorio da equipe | README raiz e arquivos em `docs/` foram atualizados para apresentacao. |
