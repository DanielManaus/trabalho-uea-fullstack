export function LoadingState({ message = 'Carregando informações...' }) {
  return <div className="state-box loading"><span className="spinner" />{message}</div>;
}

export function ErrorState({ message, onRetry }) {
  return (
    <div className="state-box error">
      <div>
        <strong>Não foi possível carregar os dados.</strong>
        <p>{message}</p>
      </div>
      {onRetry && <button className="button secondary" onClick={onRetry}>Tentar novamente</button>}
    </div>
  );
}

export function EmptyState({ title, description }) {
  return (
    <div className="state-box empty">
      <strong>{title}</strong>
      <p>{description}</p>
    </div>
  );
}

export function StatCard({ label, value, detail }) {
  return (
    <article className="stat-card">
      <span>{label}</span>
      <strong>{value}</strong>
      <small>{detail}</small>
    </article>
  );
}

export function Badge({ children, tone = 'neutral' }) {
  return <span className={`badge ${tone}`}>{children}</span>;
}

export function Notice({ type = 'success', children, onClose }) {
  return (
    <div className={`notice ${type}`}>
      <span>{children}</span>
      {onClose && <button onClick={onClose} aria-label="Fechar">×</button>}
    </div>
  );
}
