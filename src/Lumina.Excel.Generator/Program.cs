namespace Lumina.Generator;

public class Program
{
    static void Main( string[] args )
    {
        var sg = new Generator( args[ 0 ] );

        Directory.CreateDirectory( "output" );

        // foreach( var file in Directory.EnumerateFiles( "./Schemas/", "*.yml" ) )
        foreach( var file in Directory.EnumerateFiles( "./Schemas_test/", "*.yml" ) )
        {
            var name = Path.GetFileNameWithoutExtension( file );
            Console.WriteLine( $"doing sheet: {name}" );

            string code = sg.ProcessDefinition( name );
            
            // string code = "";
            // try
            // {
            //     code = sg.ProcessDefinition( name );
            //     if( code == null )
            //     {
            //         continue;
            //     }
            // }
            // catch( Exception e )
            // {
            //     Console.WriteLine($"failed sheet: {name}");
            // }
            
            var path = $"./output/{name}.cs";
            File.WriteAllText( path, code );
        }
    }
}