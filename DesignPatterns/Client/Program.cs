using AbstractFactory_Pattern.FurnitureShop;
using AbstractFactory_Pattern.FurnitureShop.Concrete_Factories;
using AbstractFactory_Pattern.Products;
using Composite_Pattern.HousingExample;
using Composite_Pattern.PlaylistApplicationExample;

namespace Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var p = 32;
			switch (p)
			{
				case 1: { compositePattern_Housing(); break; }
				case 2: { compositePattern_PlaylistApplication(); break; }
				case 31: { AbstractFactoryPattern_Products(); break; }
				case 32: { AbstractFactoryPattern_FurnitureShop(); break; }
			}
		}

		static void compositePattern_Housing()
		{
			Housing building = new Housing("123 street");
			Housing floor1 = new Housing("123 street - 1st floor");

			int firstFloor = building.addStructure(floor1);

			Room washroomMen = new Room("1F Male washroom");
			Room washroomWomen = new Room("1F Fe-Male washroom");
			Room common1 = new Room("1F Common Area");

			int firstMens = floor1.addStructure(washroomMen);
			int firstWoMens = floor1.addStructure(washroomWomen);
			int firstCommon = floor1.addStructure(common1);

			building.enter();   //Enter the building
			Housing currentFloor = (Housing)building.getStructure(firstFloor);
			currentFloor.enter();   //Walk into the First Floor
			Room currentRoom = (Room)currentFloor.getStructure(firstMens);
			currentRoom.enter();    //Walk into Men's Room (washroom)
			currentRoom.exit();    //Exiting Men's Room (washroom)
			currentRoom = (Room)currentFloor.getStructure(firstCommon);
			currentRoom.enter();//Walk into common area

		}
		static void compositePattern_PlaylistApplication()
		{
			// Make new empty "Study" playlist 
			Playlist studyPlaylist = new Playlist("Study");

			// Make "Synth Pop" playlist and add 2 songs to it.
			Playlist synthPopPlaylist = new Playlist("Synth Pop");
			Song synthPopSong1 = new Song("Girl Like You", "Toro Y Moi");
			Song synthPopSong2 = new Song("Outside", "TOPS");
			synthPopPlaylist.add(synthPopSong1);
			synthPopPlaylist.add(synthPopSong2);

			// Make "Experimental" playlist and add 3 songs to it, 
			// then set playback speed of the playlist to 0.5x
			Playlist experimentalPlaylist = new Playlist("Experimental");
			Song experimentalSong1 = new Song("About you", "XXYYXX");
			Song experimentalSong2 = new Song("Motivation", "Clams Casino");
			Song experimentalSong3 = new Song("Computer Vision", "Oneohtrix Point Never");
			experimentalPlaylist.add(experimentalSong1);
			experimentalPlaylist.add(experimentalSong2);
			experimentalPlaylist.add(experimentalSong3);
			float slowSpeed = 0.5f;
			experimentalPlaylist.setPlayBackSpeed(slowSpeed);

			// Add the "Synth Pop" playlist to the "Experimental" playlist
			experimentalPlaylist.add(synthPopPlaylist);

			// Add the "Experimental" playlist to the "Study" playlist
			studyPlaylist.add(experimentalPlaylist);

			// Create a new song and set its playback speed to 1.25x, play this song, 
			// get the name of glitchSong → "Textuell", then get the artist of this song → "Oval"
			Song glitchSong = new Song("Textuell", "Oval");
			float fasterSpeed = 1.25f;
			glitchSong.setPlayBackSpeed(fasterSpeed);
			glitchSong.play();
			String name = glitchSong.getName();
			String artist = glitchSong.getArtist();
			Console.WriteLine("The song name is " + name);
			Console.WriteLine("The song artist is " + artist);

			// Add glitchSong to the "Study" playlist
			studyPlaylist.add(glitchSong);

			// Play "Study" playlist.
			studyPlaylist.play();

			// Get the playlist name of studyPlaylist → "Study"
			Console.WriteLine("The Playlist's name is " + studyPlaylist.getName());
		}

		static void AbstractFactoryPattern_Products()
		{
			// The client code can work with any concrete factory class.
			Console.WriteLine("Client: Testing client code with the first factory type...\n");
			var Products1 = new ProductsClient(new ConcreteFactory1());
			Products1.ClientMethod();
			Console.WriteLine();
			Console.WriteLine("---------------------------------------------------------------------------\n");

			Console.WriteLine("Client: Testing the same client code with the second factory type...\n");
			var Products2 = new ProductsClient(new ConcreteFactory2());
			Products2.ClientMethod();
		}

		static void AbstractFactoryPattern_FurnitureShop()
		{
			Console.WriteLine("-----------------Order for Modern Furniture----------------------");
			IFurnitureFactory modernFactory = new ModernFurnitureFactory();
			var modernShop = new FurnitureShop(modernFactory);
			modernShop.ShowProducts();
			Console.WriteLine();

			Console.WriteLine("-----------------Order for Vintage Furniture---------------------");
			IFurnitureFactory vintageFactory = new VintageFurnitureFactory();
			var vintageShop = new FurnitureShop(vintageFactory);
			vintageShop.ShowProducts();
			Console.WriteLine();
		}
	}
}