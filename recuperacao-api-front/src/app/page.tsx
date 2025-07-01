// recuperacao-api-front/src/app/page.tsx
"use client";

import { useEffect } from 'react';
import { useRouter } from 'next/navigation';

export default function Home() {
  const router = useRouter();

  useEffect(() => {
    const token = localStorage.getItem('token');
    if (!token) {
      router.push('/login'); // Se não houver token, redireciona para a página de login
    }
  }, [router]);

  const handleLogout = () => {
    localStorage.removeItem('token');
    router.push('/login');
  };

  return (
    <div>
      <main style={{ padding: '2rem' }}>
        <h1>Dashboard Financeiro</h1>
        <p>Bem-vindo! Esta é a sua página principal.</p>
        <p>Aqui você poderá visualizar e gerenciar suas receitas e despesas.</p>
        {/* Futuramente, você adicionará os componentes de listagem e cadastro aqui */}
      </main>

      <footer className="Footer" style={{ position: 'absolute', bottom: 0, width: '100%', textAlign: 'center', padding: '1rem' }}>
          <button onClick={handleLogout} style={{ padding: '10px', cursor: 'pointer' }}>
            Sair
          </button>
          <p style={{marginTop: '1rem'}}>Projeto Guilherme Romero Da Rosa.</p>
      </footer>
    </div>
  );
}