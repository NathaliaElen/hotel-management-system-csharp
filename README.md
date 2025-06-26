# DIO - Trilha .NET - Explorando a linguagem C#

## 📌 Desafio de Projeto: Sistema de Gerenciamento de Hotel
Neste desafio, aplicamos os conceitos aprendidos no módulo **"Explorando a Linguagem C#"** da Trilha .NET da DIO.

## 📋 Contexto
Você foi contratado para construir um **sistema de hospedagem**, que será usado para realizar uma reserva em um hotel. 
O sistema envolve três classes principais:
- **Pessoa:** Representa o hóspede.
- **Suite:** Representa a suíte disponível no hotel.
- **Reserva:** Relaciona os hóspedes com uma suíte e contém regras de validação e cálculo.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a **quantidade de hóspedes** e o **valor da diária**, concedendo um **desconto de 10% para caso a reserva seja para um período maior que 10 dias**.

## ✅ Regras de Negócio e Validações Implementadas
**1. Validação de capacidade da suíte**  
Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes.    
Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.  

**2. Validação de atributos da Suíte**  
A suíte deve ter:  
- Não pode ser nula ou vazia.
- Capacidade maior que zero.  
- Valor de diária positivo (não pode ser zero ou negativo).   

**3. Validação de cadastro de hóspedes**  
- Não permite listas nulas ou vazias.  
- Nome dos hóspedes deve ter entre 3 e 30 caracteres.

**4. Método ObterQuantidadeHospedes**  
Retorna a quantidade total de hóspedes cadastrados na reserva.

**5. Método CalcularValorDiaria**  
- Calcula o valor total da reserva com base no número de dias e valor da diária.
- Se a reserva for de 10 dias ou mais, é aplicado um desconto de 10% automaticamente.

**6. Novo construtor em Reserva**  
Agora é possível criar uma reserva já vinculada a uma suíte diretamente no momento da criação, com validação automática da suíte.

**7. Tratamento de Exceções Customizadas**  
Foram criadas as exceções personalizadas:
- SuiteException
- HospedeException

Para garantir mensagens claras em caso de erros.

## 🖥️ Diagrama de Classes
![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## 🚀 Como executar o projeto
1. Clone o repositório: `git clone https://github.com/seu-usuario/hotel-management-system-csharp.git`  
2. Abra a solution no **Visual Studio** ou **VS Code**.  
3. Execute o projeto no terminal: `dotnet run`

## 🏅 Créditos
Projeto desenvolvido como parte da formação .NET Developer na [DIO](https://www.dio.me/).
