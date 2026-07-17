export const statusLabel = (value) => ({
  Backlog: 'Backlog',
  InProgress: 'Em andamento',
  Review: 'Em revisão',
  Done: 'Concluída'
}[value] || value);

export const statusTone = (value) => ({
  Backlog: 'neutral',
  InProgress: 'info',
  Review: 'warning',
  Done: 'success'
}[value] || 'neutral');

export const priorityLabel = (value) => ({
  Low: 'Baixa',
  Medium: 'Média',
  High: 'Alta',
  Critical: 'Crítica'
}[value] || value);

export const priorityTone = (value) => ({
  Low: 'neutral',
  Medium: 'info',
  High: 'warning',
  Critical: 'danger'
}[value] || 'neutral');

export const projectStatusLabel = (value) => ({
  Planning: 'Planejamento',
  Active: 'Ativo',
  OnHold: 'Em espera',
  Completed: 'Concluído'
}[value] || value);

export const projectStatusTone = (value) => ({
  Planning: 'neutral',
  Active: 'info',
  OnHold: 'warning',
  Completed: 'success'
}[value] || 'neutral');
