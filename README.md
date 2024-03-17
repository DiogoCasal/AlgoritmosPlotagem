# Projeto de Plotagem e Recorte de Linhas
Este projeto em C# visa implementar uma série de algoritmos clássicos de computação gráfica para a plotagem de linhas e círculos, além de algoritmos de recorte. Com uma interface intuitiva, o usuário pode facilmente criar formas geométricas, aplicar transformações e visualizar os resultados em tempo real. Abaixo, segue uma breve documentação sobre a estrutura do projeto e como utilizar suas principais funcionalidades.

Funcionalidades:
Funções Padrões de Click: Interface interativa para a criação de formas geométricas através de cliques.
Transformações 2D: Inclui mudança de escala, translação, rotação e reflexão, permitindo ao usuário manipular formas no espaço.
Plotagem de Linhas e Círculos: Implementação dos algoritmos de DDA e Bresenham para plotagem de linhas, além do Bresenham para círculos, oferecendo precisão e eficiência.
Algoritmos de Recorte: Incorpora os algoritmos Cohen-Sutherland e Liang-Barsky para recorte de linhas, facilitando a visualização de partes específicas de um desenho.
Métodos Auxiliares: Suporte para redimensionamento do bitmap para plotagem, garantindo flexibilidade no tamanho da área de desenho.

Como Usar:
Configuração Inicial
Certifique-se de que você tem o .NET Framework instalado em sua máquina.
Abra a solução do projeto no Visual Studio ou em um IDE de sua preferência.
Compile e execute o aplicativo para abrir a interface gráfica.

Criando e Manipulando Formas:
Para plotar linhas ou círculos: Utilize o mouse para determinar os pontos iniciais e finais da linha ou o centro e raio para círculos e posteriormente selecione o algoritmo desejado no menu de opções.
Aplicando transformações: Após desenhar uma forma, selecione-a e escolha a transformação desejada. Use os controles fornecidos para especificar os parâmetros da transformação.
Utilizando os algoritmos de recorte: Para visualizar apenas partes específicas de sua criação, selecione a ferramenta de recorte e defina a região de interesse.

Dicas Importantes:
Explore as diferentes funções de transformação para entender como elas afetam as formas no espaço.
Experimente os dois algoritmos de recorte para comparar suas eficácias em diferentes cenários.