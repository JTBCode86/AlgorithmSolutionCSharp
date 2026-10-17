# Algorithm Solution C# (.NET)

Este repositório contém uma coleção de desafios, exercícios e algoritmos clássicos de programação implementados em **C# / .NET**, organizados como uma solução modular (`AlgorithmSolution.sln`).

O objetivo deste projeto é servir como um laboratório prático para estudo e aprimoramento de **Estruturas de Dados**, **Complexidade de Algoritmos (Big O)**, **Resolução de Problemas** e boas práticas de código em C#.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **IDE Recomendada:** Visual Studio 2022, JetBrains Rider ou VS Code
* **Ferramenta de Build:** .NET CLI / MSBuild

---

## 📁 Estrutura da Solution (`AlgorithmSolution.sln`)

A solução está dividida em projetos independentes, onde cada pasta representa a resolução de um desafio ou problema algorítmico específico:

| Projeto | Descrição / Categoria |
| :--- | :--- |
| **`Algorithms.ArrayRotator`** | Algoritmos de rotação de arrays (shift/rotate de elementos à esquerda ou direita). |
| **`Algorithms.DataFilter`** | Filtragem, manipulação e transformação eficiente de coleções de dados. |
| **`Algorithms.DataStreamer`** | Processamento e manipulação de fluxos contínuos de dados (Data Streams). |
| **`Algorithms.Factorial`** | Cálculo de fatorial utilizando abordagens iterativas e recursivas. |
| **`Algorithms.ThreeSum`** | Resolução do problema 3Sum (otimizada para $O(n^2)$ com Two Pointers/HashSet). |
| **`Algorithms.ThreeSum.BruteForce`** | Resolução do problema 3Sum utilizando força bruta ($O(n^3)$) para comparação de performance. |
| **`Algorithms.TimeComplexity`** | Testes, benchmarking e medições de tempo de execução / análise de complexidade. |
| **`Algorithms.TwoSum`** | Resolução do clássico problema Two Sum utilizando Tabela Hash para busca em $O(1)$. |
| **`Algorithms.TwoSumDynamic`** | Variantes e resolução do Two Sum para entradas dinâmicas/streams de dados. |
| **`Algorithms.ValidParentheses`** | Validação de sintaxe e balanceamento de parênteses, colchetes e chaves usando **Pilha (Stack)**. |
| **`Algorithms.WorkArray`** | Operações, otimizações e manipulação genérica de vetores/arrays. |
| **`FibonacciSequence`** | Gerador e cálculo da Sequência de Fibonacci (recursão, memoização e iteração). |

---

## 🚀 Como Executar os Exercícios

### Pré-requisitos
* [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Passos no Terminal (.NET CLI)

1. **Navegar até a pasta da solução:**
   ```bash
   cd src/AlgorithmSolution
   ```

2. **Compilar a Solution completa:**
   ```bash
   dotnet build AlgorithmSolution.sln
   ```

3. **Executar um algoritmo específico:**
   Para rodar qualquer um dos projetos (substitua pelo nome da pasta desejada):
   ```bash
   dotnet run --project Algorithms.TwoSum
   ```

---

## 🧠 Tópicos e Conceitos Abordados

- **Manipulação de Arrays e Strings:** Two Pointers, Rotação e Filtragem.
- **Estruturas de Dados:** Hash Table / Dictionary, Stack (Pilha), Arrays e Listas.
- **Recursão e Algoritmos Clássicos:** Fatorial, Fibonacci.
- **Análise de Complexidade (Big O):** Comparação empírica de performance (ex: Força Bruta vs. Abordagem Otimizada).

---

## 👨‍💻 Autoria

Desenvolvido por **Jean Barbosa** como parte de estudos contínuos e consolidação de conhecimentos em C# e Ciência da Computação.