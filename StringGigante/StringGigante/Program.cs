using System; 



namespace StringGigante
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "	Lorem ipsum amet fringilla faucibus massa felis elementum vivamus nullam ultricies, placerat ullamcorper class arcu leo phasellus elementum condimentum potenti, a bibendum pretium sed elit gravida dolor mauris consectetur. sed aenean class molestie nostra conubia sodales at, aptent et quisque egestas amet non, ut auctor taciti aliquam eu et. sociosqu leo posuere dolor odio phasellus tincidunt hac arcu cubilia, suscipit tristique tincidunt eget nullam quisque maecenas litora, nullam venenatis sagittis orci turpis nibh lacus nisl. libero fames hendrerit praesent hendrerit donec nunc mauris, venenatis class urna suspendisse dolor bibendum euismod, at placerat euismod sed aliquet orci varius, blandit proin a ullamcorper donec potenti." +
                "                   Phasellus convallis pretium hendrerit phasellus quisque sit volutpat nisi tincidunt duis, semper sapien ad ipsum aliquet faucibus aliquet leo. dapibus velit pellentesque auctor pellentesque convallis curae sem viverra ipsum, primis scelerisque habitasse tempor ad egestas ipsum neque, suspendisse magna pretium accumsan congue sem eu erat. sit aliquet auctor leo vivamus nostra curabitur urna sapien lobortis aliquam class aptent, ullamcorper arcu ad fames sagittis justo pulvinar risus ipsum condimentum auctor, cras vehicula ante quam interdum habitant scelerisque nec ullamcorper donec venenatis.tristique per lacinia pharetra non conubia nullam sed nunc, dictumst cras curae porta lobortis felis elit aenean, fames donec id urna primis non class. " +
                "	Felis placerat pulvinar dui lectus potenti eu, ipsum vulputate quam volutpat odio, morbi in litora rhoncus litora.id lacinia tristique cursus curabitur facilisis ultricies senectus massa a malesuada varius, ullamcorper tincidunt adipiscing porta pellentesque phasellus dictum magna imperdiet molestie magna lacinia, placerat cras lectus ullamcorper taciti mollis justo commodo aliquam quisque.mi etiam nisi suscipit fermentum vehicula placerat posuere, lobortis velit lacus gravida nisi.ornare sem metus euismod aliquet malesuada lobortis ullamcorper sem placerat curabitur lorem eu aliquam nam hac, dui nostra purus tristique consectetur velit etiam donec scelerisque egestas vulputate risus conubia" +
                "   Himenaeos duis morbi pharetra nulla habitasse non habitasse aptent erat, euismod malesuada pellentesque dapibus scelerisque dictum habitant urna tincidunt, magna urna semper donec netus sociosqu sed hendrerit. facilisis commodo donec nunc etiam quisque habitant odio curabitur scelerisque, aenean platea praesent sit consequat ornare vivamus augue aliquet convallis, platea erat at lectus potenti habitasse fusce ut. himenaeos ornare scelerisque ante accumsan habitasse nisl vitae a feugiat condimentum duis sed taciti sagittis, libero fames dui elementum cursus proin lobortis sollicitudin gravida etiam dapibus at. semper pulvinar primis sed suspendisse amet nisl taciti feugiat, taciti venenatis mi urna pretium eget facilisis, quam bibendum sollicitudin cubilia est torquent fusce. " +
                "Congue dolor per tellus vehicula ac felis justo, ipsum quisque faucibus etiam morbi hac cubilia, nisi placerat ullamcorper risus nam ut. erat sem at condimentum congue in dictum dui fusce, nostra dictum quisque luctus ut quis sed sem, tellus ligula purus mauris fames volutpat nulla.malesuada class massa iaculis netus ad class porta id, eros urna pulvinar eleifend sem ligula.cursus iaculis ante elit magna curae quam aenean magna quam, semper tempus sollicitudin cursus cras ornare risus etiam, metus magna rhoncus adipiscing pulvinar faucibus consequat inceptos. arcu iaculis magna non mauris consequat, primis ornare semper. ";

          
            int contA=0;
            char letr ;


            Console.WriteLine($"\"{texto1}\"");

            for (int i = 0; i < texto1.Length; i++)
            { 
                letr = texto1[i];

                if (letr.Equals('a'))  
                {
               
                    contA = contA + 1;
                }
                            
            }

            Console.WriteLine($"\n\nTamanho da string : {texto1.Length}" );
            Console.WriteLine($"\nQuantidade de A : {contA}");


            string texto2 = texto1.Replace("a", "");            
            Console.WriteLine($"\nTexto sem letra A: {texto2}" );

            Console.ReadKey();
        }

     
    }
}
