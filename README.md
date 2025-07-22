# 🚗 Sistema de Estacionamento - C#

Este é um projeto simples de console desenvolvido em C# com o objetivo de simular o funcionamento de um sistema de estacionamento.

O sistema permite:

- ✅ Cadastrar veículos
- ✅ Remover veículos calculando o valor a ser pago
- ✅ Listar os veículos atualmente estacionados

---

## 🛠 Tecnologias Utilizadas

- .NET (C#)
- Programação orientada a objetos (POO)
- Console Application

---

## 📦 Como Executar o Projeto

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado (recomenda-se .NET 6 ou superior)

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/Rychardsson/SistemaEstacionamento.git
   cd SistemaEstacionamento
   ```

2. Compile e execute o projeto:
   ```bash
   dotnet run
   ```

---

## 💡 Como Utilizar

Ao rodar o projeto, será exibido um menu com as seguintes opções:

```
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

### ▶️ Exemplo de uso:

- Ao selecionar `1`, você poderá cadastrar uma placa.
- Em `2`, o sistema pedirá a placa e a quantidade de horas para calcular o valor a ser pago.
- A opção `3` lista todos os veículos estacionados no momento.
- A opção `4` encerra o sistema com confirmação.

---

## 📁 Estrutura do Projeto

```
DesafioFundamentos/
│
├── Models/
│   └── Estacionamento.cs   # Classe principal com a lógica do estacionamento
│
├── Program.cs              # Interface via console e controle do fluxo
│
└── README.md               # Documentação do projeto
```

---

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues, dar sugestões ou enviar pull requests.

---

## 📄 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
