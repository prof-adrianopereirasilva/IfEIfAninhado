
// Teste de entendimento da Lógica de Programação
// Pergunta: Em qual cenário vai aparecer a qualidade do produto?

int  qtde_produtos, qtde_estoque, qtde_compra;
string qualidade_produto;



Console.WriteLine("Digite a quantidade de produtos : " );

 qtde_produtos =  Convert.ToInt32(Console.ReadLine());
 qtde_estoque = qtde_produtos;

 Console.WriteLine("Digite a qualidade do produto : " );
 qualidade_produto = Console.ReadLine();    


 if (qtde_produtos == 0){
    Console.WriteLine("Produto Esgotado, entre em contato na próxima semana!");
 }

 else if (qtde_produtos >0 && qtde_produtos < 5)
 {
    Console.WriteLine("Ainda temos " + qtde_estoque + " em estoque.  Reposição  URGENTE!!!!!!!");   
 }
 else if(qtde_produtos <10 && qtde_estoque>0)
  {
    Console.WriteLine("Produto em estoque com quantidade inferior a 10. Atualmente " + qtde_estoque);
 }
 else if(qtde_estoque >100 ){
    Console.WriteLine("Estoque em alta, galpão de armazenamemto quase cheio. Total em estoque " + qtde_estoque);
 }

 else if(qualidade_produto == "a" ||
         qualidade_produto == "b" || 
         qualidade_produto == "c" || 
         qualidade_produto == "d" || 
         qualidade_produto == "e" )
         
        {
            Console.WriteLine("Produtos de Primeira Categoria");

        }

 else{

    Console.WriteLine("Nenhuma movimentação em estoque hoje!!!!");
    
 }