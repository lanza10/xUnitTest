namespace xUnitTest
{
    public class Apuntes
    {
        /* 
           USINGS de FLUENTASSERTIONS: 

                - using FluentAssertions;
                - using FluentAssertions.Execution;

           PATRON DE TESTING:

                1 - ARRANGE > Inicializamos las variables y objetos necesarios
                2 - ACT     > Usamos lo inicizlizado para ejecutar m�todos u obtener propiedades a testear
                3 - ASSERT  > Realizamos las aserciones que deseamos comprobar en el test

           TIPOS DE TESTS: 
               
                [Fact]   > Para comprobarr un hecho concreto 
                
                [Theory] > Se le pasan argumentos que se usaran para comprobar hechos. Para pasarle los argumentos : [InlineData(...)] tantas veces como queramos

           MÉTODOS DE ASSERT: 
                
                Assert.True(bool, string a mostrar si no se cumple(opcional))  -> Comprueba que algo sea cierto

                Assert.False(bool, string a mostrar si no se cumple(opcional)) -> Comprueba que algo no sea cierto

                Assert.Equals(objeto1, objeto2) -> Comprueba que dos objetos sean iguales

                Assert.Throws<Excepci�n que deseemos comprobar>(() => m�todo a comprobar) -> Comprueba que un m�todo lanza una excepci�n determinada

           OBSERVACIONES DE FLUENTASSERTIONS:
                
                - using var _ = new AssertionScope(): -> Nos permite realizar varias aserciones de FluentAssertions en un mismo método (sin ello, al fallar en uno
                                                        termina ahí)
                - Las evaluaciones de fluent assertions se basan en a partir de un atributo/valor para realizar compobaciones mediante Should() y encadenaciones de 
                  diferentes métodos (Be(), StartWith(), EndWith() , Contain(), BeTrue(), BeFalse() ...) mediante .And.
            
         */
    }
}

