namespace Lumina.Generator;

public class Program
{
    static void Main( string[] args )
    {
        var sg = new Generator( args[ 0 ] );

        Directory.CreateDirectory( "output" );

        foreach( var file in Directory.EnumerateFiles( "./Schemas/", "*.yml" ) )
        {
            var name = Path.GetFileNameWithoutExtension( file );
            Console.WriteLine( $"doing sheet: {name}" );
            
            var code = sg.ProcessDefinition( name );
            var path = $"./output/{name}.cs";
            
            File.WriteAllText( path, code );
        }
    }
}