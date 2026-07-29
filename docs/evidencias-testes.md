# Evidencias e testes manuais

Use este roteiro para registrar prints antes da apresentacao. Salve as imagens nesta pasta ou em uma subpasta `docs/prints/`.

## Testes realizados

| Cenario | Passos | Resultado esperado | Evidencia |
|---|---|---|---|
| Health check da API | Acessar `http://localhost:5200/health` | JSON com `status: healthy` | Print do navegador ou terminal |
| Swagger | Acessar `http://localhost:5200/swagger` | Tela Swagger com endpoints | Print do Swagger |
| Dashboard | Abrir `http://localhost:5173` | Cards e tarefas carregados | Print do front-end |
| Criar projeto | Enviar formulario de projeto valido | Projeto aparece na lista | Print antes/depois |
| Erro de conflito | Criar projeto com nome repetido | Mensagem de erro `409` exibida | Print do erro |
| Criar tarefa | Enviar tarefa vinculada a um projeto | Tarefa aparece no quadro | Print do quadro |
| Filtros | Filtrar por status, prioridade ou texto | Lista muda conforme filtro | Print do filtro |
| Alterar status | Mover/alterar status de uma tarefa | Status atualizado na API e tela | Print do resultado |
| Logs dos containers | Rodar `docker compose logs backend frontend` | Logs sem erro critico | Print ou trecho dos logs |

## Comandos usados

```bash
docker compose up --build
curl http://localhost:5200/health
curl http://localhost:5200/api/dashboard
docker compose ps
docker compose logs backend frontend
```

## Problemas encontrados e correcoes

| Problema | Causa | Correcao |
|---|---|---|
| Falta de Dockerfiles e Compose | Projeto-base focava na aplicacao, nao na entrega conteinerizada | Criados `backend/Dockerfile`, `frontend/Dockerfile` e `docker-compose.yml`. |
| CORS fixo para uma origem | A API aceitava somente `http://localhost:5173` no codigo | Origem passou a ser configuravel por `FRONTEND_ORIGIN`. |
| Documentacao de entrega incompleta | README inicial orientava apenas criacao do repositorio da equipe | README raiz e arquivos em `docs/` foram atualizados para apresentacao. |
