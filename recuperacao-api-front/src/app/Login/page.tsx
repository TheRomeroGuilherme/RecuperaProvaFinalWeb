// recuperacao-api-front/src/app/login/page.tsx
"use client";

import { useState, FormEvent } from 'react';
import { useRouter } from 'next/navigation';
import api from '../../Services/Api';

export default function LoginPage() {
  const [nome_Usuario, setUsername] = useState('');
  const [senha_Usuario, setPassword] = useState('');
  const [error, setError] = useState('');
  const router = useRouter();

  const handleLogin = async (e: FormEvent) => {
    e.preventDefault();
    setError('');

    try {
      // ATENÇÃO: Substitua 'api/Usuario/login' pelo seu endpoint de login real
      const response = await api.post('/api/Usuario/login', {
        nome_Usuario,
        senha_Usuario,
      });

      const { token } = response.data; // Supondo que sua API retorna um objeto com o token

      if (token) {
        localStorage.setItem('token', token);
        router.push('/'); // Redireciona para a página principal após o login
      } else {
        setError('Token não recebido da API.');
      }
    } catch (err) {
      setError('Falha no login. Verifique seu usuário e senha.');
      console.error(err);
    }
  };

  return (
    <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', height: '80vh' }}>
      <form onSubmit={handleLogin} style={{ display: 'flex', flexDirection: 'column', gap: '1rem', width: '300px' }}>
        <h2>Login</h2>
        <input
          type="text"
          value={nome_Usuario}
          onChange={(e) => setUsername(e.target.value)}
          placeholder="Usuário"
          required
          style={{ padding: '10px', color: '#000' }}
        />
        <input
          type="password"
          value={senha_Usuario}
          onChange={(e) => setPassword(e.target.value)}
          placeholder="Senha"
          required
          style={{ padding: '10px', color: '#000' }}
        />
        <button type="submit" style={{ padding: '10px', cursor: 'pointer' }}>Entrar</button>
        {error && <p style={{ color: 'red' }}>{error}</p>}
      </form>
    </div>
  );
}