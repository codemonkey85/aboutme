namespace aboutme.library.Pages;

// ReSharper disable once ClassNeverInstantiated.Global
public partial class Pokemon
{
    private List<PokemonData> MissingPokemon { get; set; } = new()
    {
        new PokemonData(167, "Ceruledge", "General"),
        new PokemonData(292, "Palafin", "General"),

        new PokemonData(078, "Slakoth", "Breed"),
        new PokemonData(145, "Flabébé", "Breed"),
        new PokemonData(234, "Gothita", "Breed"),
        new PokemonData(258, "Pineco", "Breed"),

        new PokemonData(261, "Scizor", "Trade Evolutions"),
        new PokemonData(326, "Slowking", "Trade Evolutions"),

        new PokemonData(386, "Iron Moth", "Paradox Pokémon"),
        new PokemonData(387, "Iron Thorns", "Paradox Pokémon"),
        new PokemonData(398, "Iron Valiant", "Paradox Pokémon"),

        new PokemonData(393, "Wo-Chien", "Legendaries"),
        new PokemonData(394, "Chien-Pao", "Legendaries"),
        new PokemonData(395, "Ting-Lu", "Legendaries"),
        new PokemonData(396, "Chi-Yu", "Legendaries"),

        new PokemonData(166, "Armarouge", "Scarlet Exclusive"),
        new PokemonData(313, "Oranguru", "Scarlet Exclusive"),
        new PokemonData(316, "Larvitar", "Scarlet Exclusive"),
        new PokemonData(317, "Pupitar", "Scarlet Exclusive"),
        new PokemonData(318, "Tyranitar", "Scarlet Exclusive"),
        new PokemonData(319, "Stonjourner", "Scarlet Exclusive"),
        new PokemonData(337, "Skrelp", "Scarlet Exclusive"),
        new PokemonData(338, "Dragalge", "Scarlet Exclusive"),

        new PokemonData(376, "Great Tusk", "Scarlet Paradox Pokémon"),
        new PokemonData(378, "Brute Bonnet", "Scarlet Paradox Pokémon"),
        new PokemonData(379, "Flutter Mane", "Scarlet Paradox Pokémon"),
        new PokemonData(380, "Slither Wing", "Scarlet Paradox Pokémon"),
        new PokemonData(381, "Sandy Shocks", "Scarlet Paradox Pokémon"),
        new PokemonData(397, "Roaring Moon", "Scarlet Paradox Pokémon"),
        new PokemonData(399, "Koraidon", "Scarlet Paradox Pokémon"),
    };
}

internal record PokemonData(int Id, string Name, string GroupName);
