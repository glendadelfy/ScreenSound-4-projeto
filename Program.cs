using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel");

        var musicasPreferidasDoJungkook = new MusicasPreferidas("Jungkook");
        
        sicasPreferidasDoJungkook.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoJungkook.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoJungkook.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoJungkook.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoJungkook.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoJungkook.ExibirMusicasFavoritas();

        var musicasPreferidasDaGlenda = new MusicasPreferidas("Glenda");

        musicasPreferidasDaGlenda.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasDaGlenda.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasDaGlenda.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasDaGlenda.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasDaGlenda.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidasDaGlenda.ExibirMusicasFavoritas();

        musicasPreferidasDaGlenda.GerarArquivoJson();



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}