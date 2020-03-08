using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class MenuLevel : MonoBehaviour {

	private Texture btnTexture1;
	public Texture bardock;
	public Texture bardock0;
	public Texture bardock1;
	public Texture bardock2;
	public Texture bardock3;
	public Texture bardock4;
	
	private Texture btnTexture2;
	public Texture raditz;
	public Texture raditz0;
	public Texture raditz1;
	public Texture raditz2;
	public Texture raditz3;
	public Texture raditz4;
	
	private Texture btnTexture3;
	public Texture nappa;
	public Texture nappa0;
	public Texture nappa1;
	public Texture nappa2;
	public Texture nappa3;
	public Texture nappa4;
	
	private Texture btnTexture4;
	public Texture gurd;
	public Texture gurd0;
	public Texture gurd1;
	public Texture gurd2;
	public Texture gurd3;
	public Texture gurd4;
	
	private Texture btnTexture5;
	public Texture reacoom;
	public Texture reacoom0;
	public Texture reacoom1;
	public Texture reacoom2;
	public Texture reacoom3;
	public Texture reacoom4;
	
	private Texture btnTexture6;
	public Texture butta;
	public Texture butta0;
	public Texture butta1;
	public Texture butta2;
	public Texture butta3;
	public Texture butta4;
	
	
	private Texture btnTexture7;
	public Texture jheese;
	public Texture jheese0;
	public Texture jheese1;
	public Texture jheese2;
	public Texture jheese3;
	public Texture jheese4;
	
	private Texture btnTexture8;
	public Texture turles;
	public Texture turles0;
	public Texture turles1;
	public Texture turles2;
	public Texture turles3;
	public Texture turles4;
	
	private Texture btnTexture9;
	public Texture ginyu;
	public Texture ginyu0;
	public Texture ginyu1;
	public Texture ginyu2;
	public Texture ginyu3;
	public Texture ginyu4;
	
	private Texture btnTexture10;
	public Texture freeza1;
	public Texture freeza1_0;
	public Texture freeza1_1;
	public Texture freeza1_2;
	public Texture freeza1_3;
	public Texture freeza1_4;
	
	private Texture btnTexture11;
	public Texture freeza2;
	public Texture freeza2_0;
	public Texture freeza2_1;
	public Texture freeza2_2;
	public Texture freeza2_3;
	public Texture freeza2_4;
	
	private Texture btnTexture12;
	public Texture freezaCyborg;
	public Texture freezaCyborg0;
	public Texture freezaCyborg1;
	public Texture freezaCyborg2;
	public Texture freezaCyborg3;
	public Texture freezaCyborg4;
	
	
	private Texture btnTexture13;
	public Texture freezaFinal;
	public Texture freezaFinal0;
	public Texture freezaFinal1;
	public Texture freezaFinal2;
	public Texture freezaFinal3;
	public Texture freezaFinal4;
	
	private Texture btnTexture14;
	public Texture cold;
	public Texture cold0;
	public Texture cold1;
	public Texture cold2;
	public Texture cold3;
	public Texture cold4;
	
	private Texture btnTexture15;
	public Texture n19;
	public Texture n19_0;
	public Texture n19_1;
	public Texture n19_2;
	public Texture n19_3;
	public Texture n19_4;
	
	private Texture btnTexture16;
	public Texture n20;
	public Texture n20_0;
	public Texture n20_1;
	public Texture n20_2;
	public Texture n20_3;
	public Texture n20_4;
	
	private Texture btnTexture17;
	public Texture fourthCooler;
	public Texture fourthCooler0;
	public Texture fourthCooler1;
	public Texture fourthCooler2;
	public Texture fourthCooler3;
	public Texture fourthCooler4;
	
	private Texture btnTexture18;
	public Texture metalCooler;
	public Texture metalCooler0;
	public Texture metalCooler1;
	public Texture metalCooler2;
	public Texture metalCooler3;
	public Texture metalCooler4;
	
	private Texture btnTexture19;
	public Texture finalCooler;
	public Texture finalCooler0;
	public Texture finalCooler1;
	public Texture finalCooler2;
	public Texture finalCooler3;
	public Texture finalCooler4;
	
	private Texture btnTexture20;
	public Texture n16;
	public Texture n16_0;
	public Texture n16_1;
	public Texture n16_2;
	public Texture n16_3;
	public Texture n16_4;
	
	private Texture btnTexture21;
	public Texture n17;
	public Texture n17_0;
	public Texture n17_1;
	public Texture n17_2;
	public Texture n17_3;
	public Texture n17_4;
	
	private Texture btnTexture22;
	public Texture n18;
	public Texture n18_0;
	public Texture n18_1;
	public Texture n18_2;
	public Texture n18_3;
	public Texture n18_4;
	
	private Texture btnTexture23;
	public Texture cellJr;
	public Texture cellJr0;
	public Texture cellJr1;
	public Texture cellJr2;
	public Texture cellJr3;
	public Texture cellJr4;
	
	private Texture btnTexture24;
	public Texture imperfectCell1;
	public Texture imperfectCell1_0;
	public Texture imperfectCell1_1;
	public Texture imperfectCell1_2;
	public Texture imperfectCell1_3;
	public Texture imperfectCell1_4;
	
	private Texture btnTexture25;
	public Texture imperfectCell2;
	public Texture imperfectCell2_0;
	public Texture imperfectCell2_1;
	public Texture imperfectCell2_2;
	public Texture imperfectCell2_3;
	public Texture imperfectCell2_4;
	
	private Texture btnTexture26;
	public Texture perfectCell;
	public Texture perfectCell0;
	public Texture perfectCell1;
	public Texture perfectCell2;
	public Texture perfectCell3;
	public Texture perfectCell4;
	
	private Texture btnTexture27;
	public Texture fatBuu;
	public Texture fatBuu0;
	public Texture fatBuu1;
	public Texture fatBuu2;
	public Texture fatBuu3;
	public Texture fatBuu4;
	
	private Texture btnTexture28;
	public Texture kidBuu;
	public Texture kidBuu0;
	public Texture kidBuu1;
	public Texture kidBuu2;
	public Texture kidBuu3;
	public Texture kidBuu4;
	
	private Texture btnTexture29;
	public Texture superBuu1;
	public Texture superBuu1_0;
	public Texture superBuu1_1;
	public Texture superBuu1_2;
	public Texture superBuu1_3;
	public Texture superBuu1_4;
	
	private Texture btnTexture30;
	public Texture superBuu2;
	public Texture superBuu2_0;
	public Texture superBuu2_1;
	public Texture superBuu2_2;
	public Texture superBuu2_3;
	public Texture superBuu2_4;
	
	private Texture btnTexture31;
	public Texture superBuu3;
	public Texture superBuu3_0;
	public Texture superBuu3_1;
	public Texture superBuu3_2;
	public Texture superBuu3_3;
	public Texture superBuu3_4;
	
	private int maxStage = 0;
	
	public GUIStyle style;
	
	public Texture btnTextureExit;

	string adUnitIdInterstitial = "ca-app-pub-8832799678197868/7199540636";
	InterstitialAd interstitial;
	AdRequest requestInterstitial;
	//levelEscolhido
	//"numEsferas"+level
	void Start () {
		//btnTexture1 = Resources.Load ("Assets/Background/Buttons/Bardock/bardock" + PlayerPrefs.GetInt ("numEsferas", 0)) as Texture;
		//GameObject go = GameObject.CreatePrimitive(PrimitiveType.Plane);
		maxStage = PlayerPrefs.GetInt("maxStage",1);
		//Screen.fullScreen = true;

		interstitial = new InterstitialAd(adUnitIdInterstitial);
		//requestInterstitial = new AdRequest.Builder().Build();
		//interstitial.LoadAd(requestInterstitial);
		
		interstitial.AdClosed += delegate(object sender, System.EventArgs args)
		{
			interstitial.Destroy();
			Application.Quit ();
		};


		
		if (maxStage >= 1) {
			switch (PlayerPrefs.GetInt("numEsferas1",0))
			{
			case 0:
				btnTexture1 = bardock0;
				break;
			case 1:
				btnTexture1 = bardock1;
				break;
			case 2:
				btnTexture1 = bardock2;
				break;
			case 3:
				btnTexture1 = bardock3;
				break;
			case 4:
				btnTexture1 = bardock4;
				break;
			default:
				btnTexture1 = bardock0;
				break;
			}
			
		} else {
			btnTexture1 = bardock;
		}
		
		if (maxStage >= 2) {
			switch (PlayerPrefs.GetInt("numEsferas2",0))
			{
			case 0:
				btnTexture2 = raditz0;
				break;
			case 1:
				btnTexture2 = raditz1;
				break;
			case 2:
				btnTexture2 = raditz2;
				break;
			case 3:
				btnTexture2 = raditz3;
				break;
			case 4:
				btnTexture2 = raditz4;
				break;
			default:
				btnTexture2 = raditz0;
				break;
			}
			
		} else {
			btnTexture2 = raditz;
		}
		
		if (maxStage >= 3) {
			switch (PlayerPrefs.GetInt("numEsferas3",0))
			{
			case 0:
				btnTexture3 = nappa0;
				break;
			case 1:
				btnTexture3 = nappa1;
				break;
			case 2:
				btnTexture3 = nappa2;
				break;
			case 3:
				btnTexture3 = nappa3;
				break;
			case 4:
				btnTexture3 = nappa4;
				break;
			default:
				btnTexture3 = nappa0;
				break;
			}
			
		} else {
			btnTexture3 = nappa;
		}
		
		if (maxStage >= 4) {
			switch (PlayerPrefs.GetInt("numEsferas4",0))
			{
			case 0:
				btnTexture4 = gurd0;
				break;
			case 1:
				btnTexture4 = gurd1;
				break;
			case 2:
				btnTexture4 = gurd2;
				break;
			case 3:
				btnTexture4 = gurd3;
				break;
			case 4:
				btnTexture4 = gurd4;
				break;
			default:
				btnTexture4 = gurd0;
				break;
			}
			
		} else {
			btnTexture4 = gurd;
		}
		
		if (maxStage >= 5) {
			switch (PlayerPrefs.GetInt("numEsferas5",0))
			{
			case 0:
				btnTexture5 = reacoom0;
				break;
			case 1:
				btnTexture5 = reacoom1;
				break;
			case 2:
				btnTexture5 = reacoom2;
				break;
			case 3:
				btnTexture5 = reacoom3;
				break;
			case 4:
				btnTexture5 = reacoom4;
				break;
			default:
				btnTexture5 = reacoom0;
				break;
			}
			
		} else {
			btnTexture5 = reacoom;
		}
		
		if (maxStage >= 6) {
			switch (PlayerPrefs.GetInt("numEsferas6",0))
			{
			case 0:
				btnTexture6 = butta0;
				break;
			case 1:
				btnTexture6 = butta1;
				break;
			case 2:
				btnTexture6 = butta2;
				break;
			case 3:
				btnTexture6 = butta3;
				break;
			case 4:
				btnTexture6 = butta4;
				break;
			default:
				btnTexture6 = butta0;
				break;
			}
			
		} else {
			btnTexture6 = butta;
		}
		
		if (maxStage >= 7) {
			switch (PlayerPrefs.GetInt("numEsferas7",0))
			{
			case 0:
				btnTexture7 = jheese0;
				break;
			case 1:
				btnTexture7 = jheese1;
				break;
			case 2:
				btnTexture7 = jheese2;
				break;
			case 3:
				btnTexture7 = jheese3;
				break;
			case 4:
				btnTexture7 = jheese4;
				break;
			default:
				btnTexture7 = jheese0;
				break;
			}
			
		} else {
			btnTexture7 = jheese;
		}
		
		if (maxStage >= 8) {
			switch (PlayerPrefs.GetInt("numEsferas8",0))
			{
			case 0:
				btnTexture8 = turles0;
				break;
			case 1:
				btnTexture8 = turles1;
				break;
			case 2:
				btnTexture8 = turles2;
				break;
			case 3:
				btnTexture8 = turles3;
				break;
			case 4:
				btnTexture8 = turles4;
				break;
			default:
				btnTexture8 = turles0;
				break;
			}
			
		} else {
			btnTexture8 = turles;
		}
		
		if (maxStage >= 9) {
			switch (PlayerPrefs.GetInt("numEsferas9",0))
			{
			case 0:
				btnTexture9 = ginyu0;
				break;
			case 1:
				btnTexture9 = ginyu1;
				break;
			case 2:
				btnTexture9 = ginyu2;
				break;
			case 3:
				btnTexture9 = ginyu3;
				break;
			case 4:
				btnTexture9 = ginyu4;
				break;
			default:
				btnTexture9 = ginyu0;
				break;
			}
			
		} else {
			btnTexture9 = ginyu;
		}
		
		if (maxStage >= 10) {
			switch (PlayerPrefs.GetInt("numEsferas10",0))
			{
			case 0:
				btnTexture10 = freeza1_0;
				break;
			case 1:
				btnTexture10 = freeza1_1;
				break;
			case 2:
				btnTexture10 = freeza1_2;
				break;
			case 3:
				btnTexture10 = freeza1_3;
				break;
			case 4:
				btnTexture10 = freeza1_4;
				break;
			default:
				btnTexture10 = freeza1_0;
				break;
			}
			
		} else {
			btnTexture10 = freeza1;
		}
		
		if (maxStage >= 11) {
			switch (PlayerPrefs.GetInt("numEsferas11",0))
			{
			case 0:
				btnTexture11 = freeza2_0;
				break;
			case 1:
				btnTexture11 = freeza2_1;
				break;
			case 2:
				btnTexture11 = freeza2_2;
				break;
			case 3:
				btnTexture11 = freeza2_3;
				break;
			case 4:
				btnTexture11 = freeza2_4;
				break;
			default:
				btnTexture11 = freeza2_0;
				break;
			}
			
		} else {
			btnTexture11 = freeza2;
		}
		
		if (maxStage >= 12) {
			switch (PlayerPrefs.GetInt("numEsferas12",0))
			{
			case 0:
				btnTexture12 = freezaCyborg0;
				break;
			case 1:
				btnTexture12 = freezaCyborg1;
				break;
			case 2:
				btnTexture12 = freezaCyborg2;
				break;
			case 3:
				btnTexture12 = freezaCyborg3;
				break;
			case 4:
				btnTexture12 = freezaCyborg4;
				break;
			default:
				btnTexture12 = freezaCyborg0;
				break;
			}
			
		} else {
			btnTexture12 = freezaCyborg;
		}
		
		if (maxStage >= 13) {
			switch (PlayerPrefs.GetInt("numEsferas13",0))
			{
			case 0:
				btnTexture13 = freezaFinal0;
				break;
			case 1:
				btnTexture13 = freezaFinal1;
				break;
			case 2:
				btnTexture13 = freezaFinal2;
				break;
			case 3:
				btnTexture13 = freezaFinal3;
				break;
			case 4:
				btnTexture13 = freezaFinal4;
				break;
			default:
				btnTexture13 = freezaFinal0;
				break;
			}
			
		} else {
			btnTexture13 = freezaFinal;
		}
		
		if (maxStage >= 14) {
			switch (PlayerPrefs.GetInt("numEsferas14",0))
			{
			case 0:
				btnTexture14 = cold0;
				break;
			case 1:
				btnTexture14 = cold1;
				break;
			case 2:
				btnTexture14 = cold2;
				break;
			case 3:
				btnTexture14 = cold3;
				break;
			case 4:
				btnTexture14 = cold4;
				break;
			default:
				btnTexture14 = cold0;
				break;
			}
			
		} else {
			btnTexture14 = cold;
		}
		
		if (maxStage >= 15) {
			switch (PlayerPrefs.GetInt("numEsferas15",0))
			{
			case 0:
				btnTexture15 = n19_0;
				break;
			case 1:
				btnTexture15 = n19_1;
				break;
			case 2:
				btnTexture15 = n19_2;
				break;
			case 3:
				btnTexture15 = n19_3;
				break;
			case 4:
				btnTexture15 = n19_4;
				break;
			default:
				btnTexture15 = n19_0;
				break;
			}
			
		} else {
			btnTexture15 = n19;
		}
		
		if (maxStage >= 16) {
			switch (PlayerPrefs.GetInt("numEsferas16",0))
			{
			case 0:
				btnTexture16 = n20_0;
				break;
			case 1:
				btnTexture16 = n20_1;
				break;
			case 2:
				btnTexture16 = n20_2;
				break;
			case 3:
				btnTexture16 = n20_3;
				break;
			case 4:
				btnTexture16 = n20_4;
				break;
			default:
				btnTexture16 = n20_0;
				break;
			}
			
		} else {
			btnTexture16 = n20;
		}
		
		if (maxStage >= 17) {
			switch (PlayerPrefs.GetInt("numEsferas17",0))
			{
			case 0:
				btnTexture17 = fourthCooler0;
				break;
			case 1:
				btnTexture17 = fourthCooler1;
				break;
			case 2:
				btnTexture17 = fourthCooler2;
				break;
			case 3:
				btnTexture17 = fourthCooler3;
				break;
			case 4:
				btnTexture17 = fourthCooler4;
				break;
			default:
				btnTexture17 = fourthCooler0;
				break;
			}
			
		} else {
			btnTexture17 = fourthCooler;
		}
		
		if (maxStage >= 18) {
			switch (PlayerPrefs.GetInt("numEsferas18",0))
			{
			case 0:
				btnTexture18 = metalCooler0;
				break;
			case 1:
				btnTexture18 = metalCooler1;
				break;
			case 2:
				btnTexture18 = metalCooler2;
				break;
			case 3:
				btnTexture18 = metalCooler3;
				break;
			case 4:
				btnTexture18 = metalCooler4;
				break;
			default:
				btnTexture18 = metalCooler0;
				break;
			}
			
		} else {
			btnTexture18 = metalCooler;
		}
		
		if (maxStage >= 19) {
			switch (PlayerPrefs.GetInt("numEsferas19",0))
			{
			case 0:
				btnTexture19 = finalCooler0;
				break;
			case 1:
				btnTexture19 = finalCooler1;
				break;
			case 2:
				btnTexture19 = finalCooler2;
				break;
			case 3:
				btnTexture19 = finalCooler3;
				break;
			case 4:
				btnTexture19 = finalCooler4;
				break;
			default:
				btnTexture19 = finalCooler0;
				break;
			}
			
		} else {
			btnTexture19 = finalCooler;
		}
		
		if (maxStage >= 20) {
			switch (PlayerPrefs.GetInt("numEsferas20",0))
			{
			case 0:
				btnTexture20 = n16_0;
				break;
			case 1:
				btnTexture20 = n16_1;
				break;
			case 2:
				btnTexture20 = n16_2;
				break;
			case 3:
				btnTexture20 = n16_3;
				break;
			case 4:
				btnTexture20 = n16_4;
				break;
			default:
				btnTexture20 = n16_0;
				break;
			}
			
		} else {
			btnTexture20 = n16;
		}
		
		if (maxStage >= 21) {
			switch (PlayerPrefs.GetInt("numEsferas21",0))
			{
			case 0:
				btnTexture21 = n17_0;
				break;
			case 1:
				btnTexture21 = n17_1;
				break;
			case 2:
				btnTexture21 = n17_2;
				break;
			case 3:
				btnTexture21 = n17_3;
				break;
			case 4:
				btnTexture21 = n17_4;
				break;
			default:
				btnTexture21 = n17_0;
				break;
			}
			
		} else {
			btnTexture21 = n17;
		}
		
		if (maxStage >= 22) {
			switch (PlayerPrefs.GetInt("numEsferas22",0))
			{
			case 0:
				btnTexture22 = n18_0;
				break;
			case 1:
				btnTexture22 = n18_1;
				break;
			case 2:
				btnTexture22 = n18_2;
				break;
			case 3:
				btnTexture22 = n18_3;
				break;
			case 4:
				btnTexture22 = n18_4;
				break;
			default:
				btnTexture22 = n18_0;
				break;
			}
			
		} else {
			btnTexture22 = n18;
		}
		
		if (maxStage >= 23) {
			switch (PlayerPrefs.GetInt("numEsferas23",0))
			{
			case 0:
				btnTexture23 = cellJr0;
				break;
			case 1:
				btnTexture23 = cellJr1;
				break;
			case 2:
				btnTexture23 = cellJr2;
				break;
			case 3:
				btnTexture23 = cellJr3;
				break;
			case 4:
				btnTexture23 = cellJr4;
				break;
			default:
				btnTexture23 = cellJr0;
				break;
			}
			
		} else {
			btnTexture23 = cellJr;
		}
		
		if (maxStage >= 24) {
			switch (PlayerPrefs.GetInt("numEsferas24",0))
			{
			case 0:
				btnTexture24 = imperfectCell1_0;
				break;
			case 1:
				btnTexture24 = imperfectCell1_1;
				break;
			case 2:
				btnTexture24 = imperfectCell1_2;
				break;
			case 3:
				btnTexture24 = imperfectCell1_3;
				break;
			case 4:
				btnTexture24 = imperfectCell1_4;
				break;
			default:
				btnTexture24 = imperfectCell1_0;
				break;
			}
			
		} else {
			btnTexture24 = imperfectCell1;
		}
		
		if (maxStage >= 25) {
			switch (PlayerPrefs.GetInt("numEsferas25",0))
			{
			case 0:
				btnTexture25 = imperfectCell2_0;
				break;
			case 1:
				btnTexture25 = imperfectCell2_1;
				break;
			case 2:
				btnTexture25 = imperfectCell2_2;
				break;
			case 3:
				btnTexture25 = imperfectCell2_3;
				break;
			case 4:
				btnTexture25 = imperfectCell2_4;
				break;
			default:
				btnTexture25 = imperfectCell2_0;
				break;
			}
			
		} else {
			btnTexture25 = imperfectCell2;
		}
		
		if (maxStage >= 26) {
			switch (PlayerPrefs.GetInt("numEsferas26",0))
			{
			case 0:
				btnTexture26 = perfectCell0;
				break;
			case 1:
				btnTexture26 = perfectCell1;
				break;
			case 2:
				btnTexture26 = perfectCell2;
				break;
			case 3:
				btnTexture26 = perfectCell3;
				break;
			case 4:
				btnTexture26 = perfectCell4;
				break;
			default:
				btnTexture26 = perfectCell0;
				break;
			}
			
		} else {
			btnTexture26 = perfectCell;
		}
		
		if (maxStage >= 27) {
			switch (PlayerPrefs.GetInt("numEsferas27",0))
			{
			case 0:
				btnTexture27 = fatBuu0;
				break;
			case 1:
				btnTexture27 = fatBuu1;
				break;
			case 2:
				btnTexture27 = fatBuu2;
				break;
			case 3:
				btnTexture27 = fatBuu3;
				break;
			case 4:
				btnTexture27 = fatBuu4;
				break;
			default:
				btnTexture27 = fatBuu0;
				break;
			}
			
		} else {
			btnTexture27 = fatBuu;
		}
		
		if (maxStage >= 28) {
			switch (PlayerPrefs.GetInt("numEsferas28",0))
			{
			case 0:
				btnTexture28 = kidBuu0;
				break;
			case 1:
				btnTexture28 = kidBuu1;
				break;
			case 2:
				btnTexture28 = kidBuu2;
				break;
			case 3:
				btnTexture28 = kidBuu3;
				break;
			case 4:
				btnTexture28 = kidBuu4;
				break;
			default:
				btnTexture28 = kidBuu0;
				break;
			}
			
		} else {
			btnTexture28 = kidBuu;
		}
		
		if (maxStage >= 29) {
			switch (PlayerPrefs.GetInt("numEsferas29",0))
			{
			case 0:
				btnTexture29 = superBuu1_0;
				break;
			case 1:
				btnTexture29 = superBuu1_1;
				break;
			case 2:
				btnTexture29 = superBuu1_2;
				break;
			case 3:
				btnTexture29 = superBuu1_2;
				break;
			case 4:
				btnTexture29 = superBuu1_4;
				break;
			default:
				btnTexture29 = superBuu1_0;
				break;
			}
			
		} else {
			btnTexture29 = superBuu1;
		}
		
		if (maxStage >= 30) {
			switch (PlayerPrefs.GetInt("numEsferas30",0))
			{
			case 0:
				btnTexture30 = superBuu2_0;
				break;
			case 1:
				btnTexture30 = superBuu2_1;
				break;
			case 2:
				btnTexture30 = superBuu2_2;
				break;
			case 3:
				btnTexture30 = superBuu2_2;
				break;
			case 4:
				btnTexture30 = superBuu2_4;
				break;
			default:
				btnTexture30 = superBuu2_0;
				break;
			}
			
		} else {
			btnTexture30 = superBuu2;
		}
		
		if (maxStage >= 31) {
			switch (PlayerPrefs.GetInt("numEsferas31",0))
			{
			case 0:
				btnTexture31 = superBuu3_0;
				break;
			case 1:
				btnTexture31 = superBuu3_1;
				break;
			case 2:
				btnTexture31 = superBuu3_2;
				break;
			case 3:
				btnTexture31 = superBuu3_2;
				break;
			case 4:
				btnTexture31 = superBuu3_4;
				break;
			default:
				btnTexture31 = superBuu3_0;
				break;
			}
			
		} else {
			btnTexture31 = superBuu3;
		}
	
	}

	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
		//Debug.Log ("Raycast: " + hit.collider.gameObject.tag);
		if (hit.collider != null && Input.GetButtonDown ("Fire1")) {
			Debug.Log ("Raycast " + hit.collider.gameObject.tag);
			if (hit.collider.gameObject.tag == "exit") {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
				} else {
					Application.Quit ();
				}
			}
		}

	
	}
	void OnGUI(){
		float bordaLateral = Screen.width / 20;
		float bordaCima = Screen.height / 20;
		
		float tamColuna = (Screen.width - bordaLateral)/7;
		float tamLinha = (Screen.height - bordaCima)/5;
		
		//COLUNA 1
		//btnTexture1.texelSize = new Vector2 (tamColuna,tamColuna);
		
		if (GUI.Button (new Rect (bordaLateral, bordaCima, tamLinha, tamLinha), btnTexture1) && maxStage >= 1) {
			PlayerPrefs.SetInt("levelEscolhido",1);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 1), bordaCima, tamLinha, tamLinha), btnTexture2) && maxStage >= 2) {
			PlayerPrefs.SetInt("levelEscolhido",2);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 2), bordaCima, tamLinha, tamLinha), btnTexture3) && maxStage >= 3) {
			PlayerPrefs.SetInt("levelEscolhido",3);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 3), bordaCima, tamLinha, tamLinha), btnTexture4) && maxStage >= 4) {
			PlayerPrefs.SetInt("levelEscolhido",4);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 4), bordaCima, tamLinha, tamLinha), btnTexture5) && maxStage >= 5) {
			PlayerPrefs.SetInt("levelEscolhido",5);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 5), bordaCima, tamLinha, tamLinha), btnTexture6) && maxStage >= 6) {
			PlayerPrefs.SetInt("levelEscolhido",6);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 6), bordaCima, tamLinha, tamLinha), btnTexture7) && maxStage >= 7) {
			PlayerPrefs.SetInt("levelEscolhido",7);
			Application.LoadLevel("Loading");
		}
		
		//COLUNA 2
		if (GUI.Button (new Rect (bordaLateral, bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture8) && maxStage >= 8) {
			PlayerPrefs.SetInt("levelEscolhido",8);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 1), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture9) && maxStage >= 9) {
			PlayerPrefs.SetInt("levelEscolhido",9);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 2), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture10) && maxStage >= 10) {
			PlayerPrefs.SetInt("levelEscolhido",10);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 3), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture11) && maxStage >= 11) {
			PlayerPrefs.SetInt("levelEscolhido",11);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 4), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture12) && maxStage >= 12) {
			PlayerPrefs.SetInt("levelEscolhido",12);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 5), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture13) && maxStage >= 13) {
			PlayerPrefs.SetInt("levelEscolhido",13);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 6), bordaCima + (tamLinha * 1), tamLinha, tamLinha), btnTexture14) && maxStage >= 14) {
			PlayerPrefs.SetInt("levelEscolhido",14);
			Application.LoadLevel("Loading");
		}
		
		//COLUNA 3
		if (GUI.Button (new Rect (bordaLateral, bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture15) && maxStage >= 15) {
			PlayerPrefs.SetInt("levelEscolhido",15);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 1), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture16) && maxStage >= 16) {
			PlayerPrefs.SetInt("levelEscolhido",16);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 2), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture17) && maxStage >= 17) {
			PlayerPrefs.SetInt("levelEscolhido",17);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 3), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture18) && maxStage >= 18) {
			PlayerPrefs.SetInt("levelEscolhido",18);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 4), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture19) && maxStage >= 19) {
			PlayerPrefs.SetInt("levelEscolhido",19);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 5), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture20) && maxStage >= 20) {
			PlayerPrefs.SetInt("levelEscolhido",20);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 6), bordaCima + (tamLinha * 2), tamLinha, tamLinha), btnTexture21) && maxStage >= 21) {
			PlayerPrefs.SetInt("levelEscolhido",21);
			Application.LoadLevel("Loading");
		}
		
		//COLUNA 4
		if (GUI.Button (new Rect (bordaLateral, bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture22) && maxStage >= 22) {
			PlayerPrefs.SetInt("levelEscolhido",22);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 1), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture23) && maxStage >= 23) {
			PlayerPrefs.SetInt("levelEscolhido",23);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 2), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture24) && maxStage >= 24) {
			PlayerPrefs.SetInt("levelEscolhido",24);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 3), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture25) && maxStage >= 25) {
			PlayerPrefs.SetInt("levelEscolhido",25);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 4), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture26) && maxStage >= 26) {
			PlayerPrefs.SetInt("levelEscolhido",26);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 5), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture27) && maxStage >= 27) {
			PlayerPrefs.SetInt("levelEscolhido",27);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 6), bordaCima + (tamLinha * 3), tamLinha, tamLinha), btnTexture28) && maxStage >= 28) {
			PlayerPrefs.SetInt("levelEscolhido",28);
			Application.LoadLevel("Loading");
		}
		
		//COLUNA 5
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 2), bordaCima + (tamLinha * 4), tamLinha, tamLinha), btnTexture29) && maxStage >= 29) {
			PlayerPrefs.SetInt("levelEscolhido",29);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 3), bordaCima + (tamLinha * 4), tamLinha, tamLinha), btnTexture30) && maxStage >= 30) {
			PlayerPrefs.SetInt("levelEscolhido",30);
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (bordaLateral + (tamColuna * 4), bordaCima + (tamLinha * 4), tamLinha, tamLinha), btnTexture31) && maxStage >= 31) {
			PlayerPrefs.SetInt("levelEscolhido",31);
			Application.LoadLevel("Loading");
		}
		
		/*if (GUI.Button (new Rect (Screen.width - (btnTextureExit.width/2) - 20, Screen.height - (btnTextureExit.height/2) - 20, btnTextureExit.width/2, btnTextureExit.height/2), btnTextureExit,style)) {
			Application.Quit();
		}*/
		
	}
}
