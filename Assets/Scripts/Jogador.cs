using UnityEngine;
using System.Collections;

using GoogleMobileAds.Api;

public class Jogador : MonoBehaviour {
	
	public GameObject inimigo;
	private Animator animatorInimigo;
	
	public GameObject jogador;
	private Animator animatorJogador;
	
	public GameObject background;
	
	private GameObject objSongoku;
	private GameObject objSongokuss1;
	private GameObject objSongokuss2;
	private GameObject objSongokuss3;
	private GameObject objSongokuss4;
	private GameObject objOozaru;
	
	private GameObject objPoder0;
	private GameObject objPoder1;
	private GameObject objPoder2;
	private GameObject objPoder3;
	private GameObject objPoder4;
	private GameObject objPoder5;
	private GameObject objPoder6;
	private GameObject objPoder6_2;
	private GameObject objPoder7;
	private GameObject objPoder8;
	private GameObject objPoder9;
	private GameObject objPoder9_2;
	private GameObject objPoder10;
	private GameObject objPoder11;
	private GameObject objPoder11_2;
	private GameObject objPoder12;
	private GameObject objPoder13;
	private GameObject objPoder14;
	private GameObject objPoder15;
	private GameObject objPoder18;
	private GameObject objPoder19;
	private GameObject objPoderInimigoEscolhido;
	
	public GameObject ready;
	public GameObject go;
	public GameObject start;
	public GameObject primeiraVez;
	public GameObject nextStageImg;
	private bool mostraMsg = false;
	public float tempoTotal;
	public float delayTempoTotal;
	
	public GUIStyle styleStage;
	public GUIStyle styleStageCombo;
	
	private GameObject objBardock;
	private GameObject objButta;
	private GameObject objChibiBuu;
	private GameObject objFatBuu;
	private GameObject objSuperBuu1;
	private GameObject objSuperBuu2;
	private GameObject objSuperBuu3;
	private GameObject objCellJr;
	private GameObject objImperfectCell1;
	private GameObject objImperfectCell2;
	private GameObject objPerfectCell;
	private GameObject objCold;
	private GameObject objFinalCooler;
	private GameObject objFourthCooler;
	private GameObject objMetalCooler;
	private GameObject objFreeza1;
	private GameObject objFreeza2;
	private GameObject objFreezaCyborg;
	private GameObject objFreezaFinal;
	private GameObject objGinyu;
	private GameObject objGurd;
	private GameObject objJheese;
	private GameObject objN16;
	private GameObject objN17;
	private GameObject objN18;
	private GameObject objN19;
	private GameObject objN20;
	private GameObject objNappa;
	private GameObject objRaditz;
	private GameObject objReacoom;
	private GameObject objTurtles;
	
	private GameObject ultimoInimigo;
	
	private GameObject objPoderCarrega1;
	private GameObject objPoderCarrega2;
	private GameObject objPoderCarregass4;
	private GameObject objPoderRapido1;
	private GameObject objPoderRapido2;
	private GameObject objPoderRapidoss4;
	private GameObject objMostraMoon;
	
	private GameObject objPoderAparece1;
	private GameObject objPoderAparece2;
	private GameObject objPoderAparecess4;
	private GameObject objMoonAparece;
	private GameObject objPoderApareceDesce;
	private GameObject tipoPoderCarrega;
	
	private GameObject objGoSprite;
	
	private GameObject objTransformaSS1;
	private GameObject objTransformaSS2;
	private GameObject objTransformaSS3;
	private GameObject objTransformaSS4;
	private GameObject objTransformaMoon;
	private GameObject objTransformaAparece;
	
	private GameObject poderAmigo;
	
	public GameObject healthbarJogador;
	
	private GameObject objHealthBarJ0;
	private GameObject objHealthBarJ1;
	private GameObject objHealthBarJ2;
	private GameObject objHealthBarJ3;
	private GameObject objHealthBarJ4;
	private GameObject objHealthBarJ5;
	private GameObject objHealthBarJ6;
	private GameObject objHealthBarJ7;
	private GameObject objHealthBarJ8;
	private GameObject objHealthBarJ9;
	private GameObject objHealthBarJ10;
	
	public GameObject healthbarInimigo;
	
	//public GameObject healthbarJogador;
	private GameObject objHealthBarI0;
	private GameObject objHealthBarI1;
	private GameObject objHealthBarI2;
	private GameObject objHealthBarI3;
	private GameObject objHealthBarI4;
	private GameObject objHealthBarI5;
	private GameObject objHealthBarI6;
	private GameObject objHealthBarI7;
	private GameObject objHealthBarI8;
	private GameObject objHealthBarI9;
	private GameObject objHealthBarI10;
	
	public AudioClip soco;
	public AudioClip socoForte;
	public AudioClip chute;
	public AudioClip aura;
	public AudioClip auraOozaru;
	public AudioClip teleport;
	public AudioClip teleportReverse;
	public AudioClip poderCarregaFire;
	public AudioClip poderCarregaCharge;
	public AudioClip poderRapido;
	public AudioClip azulCharge;
	public AudioClip azulFire;
	public AudioClip somGrito;
	public AudioClip ultrassonGurd;
	public AudioClip roxoGritoCharge;
	public AudioClip roxoGritoFire;
	public AudioClip auraCharge;
	public AudioClip auraFire;
	public AudioClip fingerLaser;
	public AudioClip amareloCarrega;
	public AudioClip amareloFire;
	public AudioClip bateParede;
	
	private bool somAzul = false;
	private bool somKame = false;
	private bool somRoxoGrito = false;
	private bool somAura = false;
	private bool somAmarelo = false;
	private bool acabou = false;
	private bool teleporteInicio = false;
	
	private bool somTeleport = true;
	
	
	private float velocidade = 1;
	private float velocidadeDesce = 3f;
	private float forcaJogador = 1;
	//private float forcaInimigo = 1;
	private float dificuldade = 5;
	private float vidaJogador;
	private float vidaInimigo;
	
	private float vida = 200;
	public float frequenciaGolpes =  0.2f;
	public float delayFrequenciaGolpes =  0.2f;
	public int frequenciaPoderesJ = 50;
	public int frequenciaPoderesI = 30;
	
	public int level = 1;
	private int combo = 0;
	
	private bool pegouObj = false;
	
	private bool transformacao = false;
	private float tempoTrans = 0f;
	private float delayTrans = 2.0f;
	private float meiaTransformacao;
	private int nivel = 0;
	
	//private float ultimoGolpe = 0.1f;
	private float volumeBatida = 0.2f;
	private float volume = 0.5f;
	private bool iniciou = false;
	
	//private int frequenciaPoderesInicio = 50;
	//private float frequenciaGolpesInicio =  0.2f;
	
	//private int forcaAtaque = 5;
	private bool poderJogadorCarrega = false;
	private bool poderJogadorRapido = false;
	private bool poderInimigoRapido = false;
	private bool poderInimigoCarrega = false;
	private float delayAtaque = 4.0f;
	private float delayAtaqueRapido = 2.0f;
	//private float delayPoderAtaqueRapido = 0.01f;
	private float poderAtaqueRapido = 0.0f;
	private float carregaAtaque = 1.0f;
	private float tempoAtaque = 0f;
	private float distance = 0;
	private float teleporteSome = 0.4f;
	private float teleporteAparece = 0.4f;
	private float delayTeleport = 0.4f;
	private bool mudaPosition = false;
	private bool mostraTextoCombo = false;
	private int minCombo = 10;
	
	
	public float tamBotao = 100.0f;
	private float tempoSaiyajin = 0.0f;
	private float delayTempoSaiyajin = 5.0f;
	private bool saiyajin = false;
	private bool oozaru = false;
	private bool descePoder = false;
	private bool transformacaoDesce = false;
	private int nivelTrans = 0;
	private int inimigoEscolhido = 0;
	//private int ultimaEscolha = 0;
	private float delayProxLevel = 4.0f;
	//private float tempoProxLevel = 4.0f;
	private bool animaFinalI = false;
	private bool animaFinalJ = false;
	
	private Animator animatorVencedor;
	private Animator animatorPerdedor;
	private float delayRodopia = 1f;
	private float tempoRodopia = 1f;
	private float delayCair = 1.5f;
	private float tempoCair = 1.5f;
	private float delayGolpe = 0.3f;
	private float tempoGolpe = 0.3f;
	private bool somBateParede = true;
	private Vector3 posAntesBate;
	private int pontos = 0;
	private int contHits = 0;
	
	
	private Vector2 posReadyGo;
	
	//nome inimigo
	string bardock = "Inimigo/bardock_1";
	string butta = "Inimigo/butta_1";
	string fatBuu = "Inimigo/buu_7";
	string superBuu1 = "Inimigo/buu_40";
	string superBuu2 = "Inimigo/buu_74";
	string superBuu3 = "Inimigo/buu_108";
	string chibiBuu = "Inimigo/buu_142";
	string imperfectCell1 = "Inimigo/cell_5";
	string imperfectCell2 = "Inimigo/cell_39";
	string perfectCell = "Inimigo/cell_72";
	string cellJr = "Inimigo/cell_105";
	string cold = "Inimigo/cold_1";
	string fourthCooler = "Inimigo/cooler_3";
	string finalCooler = "Inimigo/cooler_38";
	string metalCooler = "Inimigo/cooler_69";
	string freeza1 = "Inimigo/freeza_6";
	string freeza2 = "Inimigo/freeza_39";
	string freezaFinal = "Inimigo/freeza_71";
	string freezaCyborg = "Inimigo/freeza_105";
	string ginyu = "Inimigo/ginyu_1";
	string gurd = "Inimigo/gurd_1";
	string jheese = "Inimigo/jheese_1";
	string n16 = "Inimigo/n16_1";
	string n17 = "Inimigo/n17_1";
	string n18 = "Inimigo/n18_1";
	string n19 = "Inimigo/n19_1";
	string n20 = "Inimigo/n20_1";
	string nappa = "Inimigo/nappa_1";
	string raditz = "Inimigo/raditz_1";
	string reacoom = "Inimigo/reacoom_1";
	string turtles = "Inimigo/turtles_2";
	
	//nome skin inimigo
	string bardockSkin = "Inimigo/Mini/bardock_0";
	string buttaSkin = "Inimigo/Mini/butta_0";
	string fatBuuSkin = "Inimigo/Mini/buu_1";
	string superBuu1Skin = "Inimigo/Mini/buu_2";
	string superBuu2Skin = "Inimigo/Mini/buu_4";
	string superBuu3Skin = "Inimigo/Mini/buu_5";
	string chibiBuuSkin = "Inimigo/Mini/buu_6";
	string imperfectCell1Skin = "Inimigo/Mini/cell_0";
	string imperfectCell2Skin = "Inimigo/Mini/cell_1";
	string perfectCellSkin = "Inimigo/Mini/cell_2";
	string cellJrSkin = "Inimigo/Mini/cell_4";
	string coldSkin = "Inimigo/Mini/cold_0";
	string fourthCoolerSkin = "Inimigo/Mini/cooler_0";
	string finalCoolerSkin = "Inimigo/Mini/cooler_1";
	string metalCoolerSkin = "Inimigo/Mini/cooler_2";
	string freeza1Skin = "Inimigo/Mini/freeza_0";
	string freeza2Skin = "Inimigo/Mini/freeza_2";
	string freezaFinalSkin = "Inimigo/Mini/freeza_3";
	string freezaCyborgSkin = "Inimigo/Mini/freeza_4";
	string ginyuSkin = "Inimigo/Mini/ginyu_0";
	string gurdSkin = "Inimigo/Mini/gurd_0";
	string jheeseSkin = "Inimigo/Mini/jheese_0";
	string n16Skin = "Inimigo/Mini/n16_0";
	string n17Skin = "Inimigo/Mini/n17_0";
	string n18Skin = "Inimigo/Mini/n18_0";
	string n19Skin = "Inimigo/Mini/n19_0";
	string n20Skin = "Inimigo/Mini/n20_0";
	string nappaSkin = "Inimigo/Mini/nappa_0";
	string raditzSkin = "Inimigo/Mini/raditz_0";
	string reacoomSkin = "Inimigo/Mini/reacoom_0";
	string turtlesSkin = "Inimigo/Mini/turtles_0";
	
	//nome skin inimigo
	string songokuSkin = "Jogador/Mini/songoku_0";
	string songokuSS1Skin = "Jogador/Mini/songoku_4";
	string songokuSS2Skin = "Jogador/Mini/songoku_5";
	string songokuSS3Skin = "Jogador/Mini/songoku_6";
	string songokuSS4Skin = "Jogador/Mini/ss4mini";
	string oozaruSkin = "Jogador/Mini/oMini";
	
	//poderews inimigo
	string poderesI0 = "Inimigo/Poderes/poderes_0";
	string poderesI1 = "Inimigo/Poderes/poderes_1";
	string poderesI2 = "Inimigo/Poderes/poderes_2";
	string poderesI3 = "Inimigo/Poderes/poderes_3";
	string poderesI4 = "Inimigo/Poderes/poderes_4";
	string poderesI5 = "Inimigo/Poderes/poderes_5";
	string poderesI6 = "Inimigo/Poderes/poderes_6";
	string poderesI6_2 = "Inimigo/Poderes/poderes_6_2";
	string poderesI7 = "Inimigo/Poderes/poderes_7";
	string poderesI8 = "Inimigo/Poderes/poderes_8";
	string poderesI9 = "Inimigo/Poderes/poderes_9";
	string poderesI9_2 = "Inimigo/Poderes/poderes_9_2";
	string poderesI10 = "Inimigo/Poderes/poderes_10";
	string poderesI11 = "Inimigo/Poderes/poderes_11";
	string poderesI11_2 = "Inimigo/Poderes/poderes_11_2";
	string poderesI12 = "Inimigo/Poderes/poderes_12";
	string poderesI13 = "Inimigo/Poderes/poderes_13";
	string poderesI14 = "Inimigo/Poderes/poderes_14";
	string poderesI15 = "Inimigo/Poderes/poderes_15";
	string poderesI18 = "Inimigo/Poderes/poderes_18";
	string poderesI19 = "Inimigo/Poderes/poderes_19";
	
	string strAnimacaoInimigo;
	
	//nome jogador
	string songokuss1 = "Jogador/songoku_46";
	string songokuss2 = "Jogador/songoku_86";
	string songokuss3 = "Jogador/songoku_126";
	string songokuss4 = "Jogador/ss4_0";
	string songoku = "Jogador/songoku_7";
	string stroozaru = "Jogador/oozaru_2";
	string mostraMoon = "Background/moon";
	
	//nome poder jogador
	string spoderCarrega1 = "Jogador/Poderes/poderes_0";
	string spoderCarrega2 = "Jogador/Poderes/poderes_1";
	string spoderCarregass4 = "Jogador/Poderes/poderss4_0";
	string spoderRapido1 = "Jogador/Poderes/poderes_6";
	string spoderRapido2 = "Jogador/Poderes/poderes_9";
	string spoderRapidoss4 = "Jogador/Poderes/poderss4_1";
	
	//poderes aparece
	string poderAparece0 = "PoderesAparece/poderesAparece_0";
	string poderAparece1 = "PoderesAparece/poderesAparece_1";
	string poderAparecess4 = "PoderesAparece/poderesAparecess4_0";
	
	//transforma aparece
	string transformaApareceSS1 = "TransformaAparece/songokuTrans_0";
	string transformaApareceSS2 = "TransformaAparece/songokuTrans_1";
	string transformaApareceSS3 = "TransformaAparece/songokuTrans_2";
	string transformaApareceSS4 = "TransformaAparece/songokuTransss4_0";
	string moonAparece = "TransformaAparece/moon";
	
	//healthbar jogador
	string healthBarJ0 = "Jogador/HealthbarJogador/healthbar_10";
	string healthBarJ1 = "Jogador/HealthbarJogador/healthbar_9";
	string healthBarJ2 = "Jogador/HealthbarJogador/healthbar_8";
	string healthBarJ3 = "Jogador/HealthbarJogador/healthbar_7";
	string healthBarJ4 = "Jogador/HealthbarJogador/healthbar_6";
	string healthBarJ5 = "Jogador/HealthbarJogador/healthbar_5";
	string healthBarJ6 = "Jogador/HealthbarJogador/healthbar_4";
	string healthBarJ7 = "Jogador/HealthbarJogador/healthbar_3";
	string healthBarJ8 = "Jogador/HealthbarJogador/healthbar_2";
	string healthBarJ9 = "Jogador/HealthbarJogador/healthbar_1";
	string healthBarJ10 = "Jogador/HealthbarJogador/healthbar_0";
	
	//healthbar inimigo
	string healthBarI0 = "Inimigo/HealthbarInimigo/healthbar_21";
	string healthBarI1 = "Inimigo/HealthbarInimigo/healthbar_20";
	string healthBarI2 = "Inimigo/HealthbarInimigo/healthbar_19";
	string healthBarI3 = "Inimigo/HealthbarInimigo/healthbar_18";
	string healthBarI4 = "Inimigo/HealthbarInimigo/healthbar_17";
	string healthBarI5 = "Inimigo/HealthbarInimigo/healthbar_16";
	string healthBarI6 = "Inimigo/HealthbarInimigo/healthbar_15";
	string healthBarI7 = "Inimigo/HealthbarInimigo/healthbar_14";
	string healthBarI8 = "Inimigo/HealthbarInimigo/healthbar_13";
	string healthBarI9 = "Inimigo/HealthbarInimigo/healthbar_12";
	string healthBarI10 = "Inimigo/HealthbarInimigo/healthbar_11";
	
	private GameObject objImgFinal0;
	private GameObject objImgFinal1;
	private GameObject objImgFinal2;
	private GameObject objImgFinal3;
	private GameObject objImgFinal4;
	private GameObject objImgFinal5;
	private GameObject objImgFinal6;
	private GameObject objImgFinalChen;
	
	string imgFinal0 = "Background/imgFinal0";
	string imgFinal1 = "Background/imgFinal1";
	string imgFinal2 = "Background/imgFinal2";
	string imgFinal3 = "Background/imgFinal3";
	string imgFinal4 = "Background/imgFinal4";
	string imgFinal5 = "Background/imgFinal5";
	string imgFinal6 = "Background/imgFinal6";
	string imgFinalChen = "Background/imgFinalChen";
	
	Vector3 posSkinJogador;
	
	GameObject objSongokuSkin;
	GameObject objSongokuSS1Skin;
	GameObject objSongokuSS2Skin;
	GameObject objSongokuSS3Skin;
	GameObject objSongokuSS4Skin;
	GameObject objOozaruSkin;
	
	
	string goSprite = "Background/goSprite_36";
	string cover = "Background/cover";
	
	Vector3 screenPositionToque;
	Vector3 scaleGo;
	
	float tempoEspera = 1f;
	
	private int maxPontosPlayer = 0;
	private int maxStagePlayer = 0;
	private GameObject sr;
	
	string adUnitId = "ca-app-pub-8832799678197868/8083085034";
	BannerView bannerView;
	AdRequest request;

	string adUnitIdInterstitial = "ca-app-pub-8832799678197868/9559818234";
	InterstitialAd interstitial;
	AdRequest requestInterstitial;



	//private bool debug = false;
	private int mute = 0;
	private AudioSource audio;

	private bool isPlay = true;
	public GameObject frump;

	public GameObject playButton;
	public GameObject pauseButton;
	public GameObject vibrateOffButton;
	public GameObject vibrateOnButton;
	public GameObject volumeOnButton;
	public GameObject volumeMutedButton;

	public GameObject exitButton;
	public GameObject backButton;
	public GameObject againButton;

	public GameObject objStage;
	public GameObject objPoints;
	public GameObject objCombo;


	public GameObject objStageFim;
	public GameObject objPointsFim;
	public GameObject objStageFimMax;
	public GameObject objPointsFimMax;

	private TextMesh textCombo;
	private TextMesh textPoints;
	private TextMesh textStage;
	
	private TextMesh textPointsFim;
	private TextMesh textStageFim;
	private TextMesh textPointsFimMax;
	private TextMesh textStageFimMax;


	void Start () {

		textCombo = objCombo.GetComponent <TextMesh>();
		textPoints = objPoints.GetComponent <TextMesh>();
		textStage = objStage.GetComponent <TextMesh>();
		textCombo.text = "";

		textPointsFim = objPointsFim.GetComponent <TextMesh>();
		textStageFim = objStageFim.GetComponent <TextMesh>();
		textPointsFimMax = objPointsFimMax.GetComponent <TextMesh>();
		textStageFimMax = objStageFimMax.GetComponent <TextMesh>();
		textPointsFim.text = "";
		textStageFim.text = "";
		textPointsFimMax.text = "";
		textStageFimMax.text = "";

		//againButton.SetActive (false);
		//backButton.SetActive (false);

		/*if (Screen.width <= 720) {
			divideTam = 4f;
		}else if (Screen.width < 1920 && Screen.width > 720) {
			divideTam = 2f;
		}
		else if (Screen.width >= 1920) {
			divideTam = 1f;
		}*/

		if (PlayerPrefs.GetString ("mostraFrump") != "nao") {
			isPlay = false;
			frump.SetActive(true);
		} else {
			isPlay = true;
			frump.SetActive(false);
		}


		//banner
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
		request = new AdRequest.Builder().Build();
		bannerView.LoadAd(request);
		bannerView.Hide ();

		//interstitial
		interstitial = new InterstitialAd(adUnitIdInterstitial);
		//requestInterstitial = new AdRequest.Builder().Build();
		//interstitial.LoadAd(requestInterstitial);

		interstitial.AdClosed += delegate(object sender, System.EventArgs args)
		{
			interstitial.Destroy();
			Application.Quit ();
		};

		

		//play_pause = pause;

		scaleGo = new Vector3(go.transform.localScale.x , go.transform.localScale.y , go.transform.localScale.z);

		tempoTotal = delayProxLevel - delayRodopia - delayCair - delayGolpe + tempoEspera;
		delayTempoTotal = tempoTotal;
		ready.SetActive(false);
		go.SetActive(false);
		objGoSprite = GameObject.Find (goSprite);
		//Screen.fullScreen = true;
		
		
		objImgFinal0 = GameObject.Find (imgFinal0);
		objImgFinal1 = GameObject.Find (imgFinal1);
		objImgFinal2 = GameObject.Find (imgFinal2);
		objImgFinal3 = GameObject.Find (imgFinal3);
		objImgFinal4 = GameObject.Find (imgFinal4);
		objImgFinal5 = GameObject.Find (imgFinal5);
		objImgFinal6 = GameObject.Find (imgFinal6);
		objImgFinalChen = GameObject.Find (imgFinalChen);
		objImgFinal0.SetActive (false);
		objImgFinal1.SetActive (false);
		objImgFinal2.SetActive (false);
		objImgFinal3.SetActive (false);
		objImgFinal4.SetActive (false);
		objImgFinal5.SetActive (false);
		objImgFinal6.SetActive (false);
		objImgFinalChen.SetActive (false);
		
		sr = GameObject.Find (cover);
		
		
		maxPontosPlayer = PlayerPrefs.GetInt("maxPontos");
		maxStagePlayer = PlayerPrefs.GetInt("maxStage");
		
		ResizeSpriteToScreen ();
		
		start.SetActive(false);

		
		//Debug.Log ("maxPontos" + maxPontosPlayer);
		//Debug.Log ("maxStage" + maxStagePlayer);
		
		objSongoku = GameObject.Find (songoku);
		objSongokuss1 = GameObject.Find (songokuss1);
		objSongokuss2 = GameObject.Find (songokuss2);
		objSongokuss3 = GameObject.Find (songokuss3);
		objSongokuss4 = GameObject.Find (songokuss4);
		objOozaru = GameObject.Find (stroozaru);
		objMostraMoon = GameObject.Find (mostraMoon);
		objSongokuss1.SetActive (false);
		objSongokuss2.SetActive (false);
		objSongokuss3.SetActive (false);
		objSongokuss4.SetActive (false);
		objMostraMoon.SetActive (false);
		objOozaru.SetActive (false);
		//GameObject.Find(songoku).SetActive (false);
		
		jogador = objSongoku;
		jogador.SetActive (true);
		animatorJogador = jogador.transform.GetComponent<Animator> ();
		
		objPoderCarrega1 = GameObject.Find (spoderCarrega1);
		objPoderCarregass4 = GameObject.Find (spoderCarregass4);
		objPoderCarrega2 = GameObject.Find (spoderCarrega2);
		objPoderRapido1 = GameObject.Find (spoderRapido1);
		objPoderRapido2 = GameObject.Find (spoderRapido2);
		objPoderRapidoss4 = GameObject.Find (spoderRapidoss4);
		//poderes
		objPoderCarrega1.SetActive (false);
		objPoderCarrega2.SetActive (false);
		objPoderRapido1.SetActive (false);
		objPoderRapido2.SetActive (false);
		objPoderCarregass4.SetActive (false);
		objPoderRapidoss4.SetActive (false);
		
		//poder aparece
		objPoderAparece1 = GameObject.Find (poderAparece0);
		objPoderAparece2 = GameObject.Find (poderAparece1);
		objPoderAparecess4 = GameObject.Find (poderAparecess4);
		objPoderAparece1.SetActive(false);
		objPoderAparece2.SetActive(false);
		objPoderAparecess4.SetActive (false);
		
		//transforma aparece
		objTransformaSS1 = GameObject.Find (transformaApareceSS1);
		objTransformaSS2 = GameObject.Find (transformaApareceSS2);
		objTransformaSS3 = GameObject.Find (transformaApareceSS3);
		objTransformaSS4 = GameObject.Find (transformaApareceSS4);
		objTransformaMoon= GameObject.Find (moonAparece);
		objTransformaSS1.SetActive (false);
		objTransformaSS2.SetActive (false);
		objTransformaSS3.SetActive (false);
		objTransformaSS4.SetActive (false);
		objTransformaMoon.SetActive (false);
		
		//inimigos
		level = PlayerPrefs.GetInt("levelEscolhido");
		if(level > 1){
			primeiraVez.SetActive(false);
		}
		SorteiaInimigo ();
		
		
		//heathbar jogador
		objHealthBarJ0 = GameObject.Find (healthBarJ0);
		objHealthBarJ1 = GameObject.Find (healthBarJ1);
		objHealthBarJ2 = GameObject.Find (healthBarJ2);
		objHealthBarJ3 = GameObject.Find (healthBarJ3);
		objHealthBarJ4 = GameObject.Find (healthBarJ4);
		objHealthBarJ5 = GameObject.Find (healthBarJ5);
		objHealthBarJ6 = GameObject.Find (healthBarJ6);
		objHealthBarJ7 = GameObject.Find (healthBarJ7);
		objHealthBarJ8 = GameObject.Find (healthBarJ8);
		objHealthBarJ9 = GameObject.Find (healthBarJ9);
		objHealthBarJ10 = GameObject.Find (healthBarJ10);
		objHealthBarJ0.SetActive (false);
		objHealthBarJ1.SetActive (false);
		objHealthBarJ2.SetActive (false);
		objHealthBarJ3.SetActive (false);
		objHealthBarJ4.SetActive (false);
		objHealthBarJ5.SetActive (false);
		objHealthBarJ6.SetActive (false);
		objHealthBarJ7.SetActive (false);
		objHealthBarJ8.SetActive (false);
		objHealthBarJ9.SetActive (false);
		objHealthBarJ9.SetActive (false);
		
		healthbarJogador = objHealthBarJ10;
		
		//heathbar inimigo
		objHealthBarI0 = GameObject.Find (healthBarI0);
		objHealthBarI1 = GameObject.Find (healthBarI1);
		objHealthBarI2 = GameObject.Find (healthBarI2);
		objHealthBarI3 = GameObject.Find (healthBarI3);
		objHealthBarI4 = GameObject.Find (healthBarI4);
		objHealthBarI5 = GameObject.Find (healthBarI5);
		objHealthBarI6 = GameObject.Find (healthBarI6);
		objHealthBarI7 = GameObject.Find (healthBarI7);
		objHealthBarI8 = GameObject.Find (healthBarI8);
		objHealthBarI9 = GameObject.Find (healthBarI9);
		objHealthBarI10 = GameObject.Find (healthBarI10);
		objHealthBarI0.SetActive (false);
		objHealthBarI1.SetActive (false);
		objHealthBarI2.SetActive (false);
		objHealthBarI3.SetActive (false);
		objHealthBarI4.SetActive (false);
		objHealthBarI5.SetActive (false);
		objHealthBarI6.SetActive (false);
		objHealthBarI7.SetActive (false);
		objHealthBarI8.SetActive (false);
		objHealthBarI9.SetActive (false);
		objHealthBarI9.SetActive (false);
		
		healthbarInimigo = objHealthBarI10;
		
		meiaTransformacao = delayTrans / 2;
		
		delayTempoSaiyajin += delayTrans;
		
		vidaJogador = vidaInimigo = vida;
		
		animatorInimigo = inimigo.transform.GetComponent<Animator> ();
		
		inimigo.transform.Translate (Vector2.right*4f*(-1));
		jogador.transform.Translate (Vector2.right*4f*(-1));
		nextStageImg.SetActive(false);
		
		
		objSongokuSS1Skin = GameObject.Find (songokuSS1Skin);
		objSongokuSS2Skin = GameObject.Find (songokuSS2Skin);
		objSongokuSS3Skin = GameObject.Find (songokuSS3Skin);
		objSongokuSS4Skin = GameObject.Find (songokuSS4Skin);
		objOozaruSkin = GameObject.Find (oozaruSkin);
		objSongokuSkin = GameObject.Find (songokuSkin);
		
		objSongokuSS1Skin.SetActive (false);
		objSongokuSS2Skin.SetActive (false);
		objSongokuSS3Skin.SetActive (false);
		objSongokuSS4Skin.SetActive (false);
		objOozaruSkin.SetActive (false);
		
		objSkinJogador = objSongokuSkin;



		int vibratePrefs = PlayerPrefs.GetInt ("vibrate", 1);

		if (vibratePrefs == 0) {
			vibrateOffButton.SetActive(true);
			vibrateOnButton.SetActive(false);
			vibrate = false;
			//vibrateOnOff = vibrateOff;
			
		} else {
			vibrateOffButton.SetActive(false);
			vibrateOnButton.SetActive(true);
			vibrate = true;
			//vibrateOnOff = vibrateOn;
		}

		pauseButton.SetActive (false);
		audio = Camera.main.GetComponent<AudioSource>();
		mute = PlayerPrefs.GetInt ("mute", 1);
		if (mute == 0) {
			volumeOnButton.SetActive(false);
			volumeMutedButton.SetActive(true);
			audio.mute = true;

			muteSom = true;

		} else {
			volumeOnButton.SetActive(true);
			volumeMutedButton.SetActive(false);
			audio.mute = false;
			;
			muteSom = false;


		}


	}

	private bool muteSom = false;
	
	void Update () {
		if (isPlay) { //TODO
			//nextStageImg
			if (mostraMsg) {
			
				Vector2 posReadyGo = new Vector2 (jogador.transform.position.x + 4.6f, jogador.transform.position.y);
			
				if (delayTempoTotal == tempoTotal) {
					nextStageImg.SetActive (true);
					nextStageImg.transform.position = posReadyGo;
					ready.SetActive (true);
					ready.transform.position = posReadyGo;
					ready.SetActive (false);
				
				}
				nextStageImg.transform.Translate (Vector2.up * Time.deltaTime * 0.5f);
			
				delayTempoTotal -= Time.deltaTime;
			
				if (delayTempoTotal <= (tempoTotal / 3) * 2) {
				
					nextStageImg.SetActive (false);
					ready.SetActive (true);
				
					ready.transform.Translate (Vector2.up * Time.deltaTime * (-0.5f));	
				}
			
				if (delayTempoTotal <= tempoTotal / 3) {
				
					ready.SetActive (false);
					go.SetActive (true);	
					go.transform.localScale = new Vector3 (go.transform.localScale.x * 1.002f, go.transform.localScale.y * 1.002f, go.transform.localScale.z);
					go.transform.position = posReadyGo;
				}
			
				if (delayTempoTotal <= 0) {
					ready.SetActive (false);
					go.SetActive (false);
					nextStageImg.SetActive (false);
					go.transform.localScale = scaleGo;
					delayTempoTotal = tempoTotal;
				
					tempoEspera = 1f;
					acabou = false;
					teleporteInicio = true;
					mostraMsg = false;
				}
			
			}
		
			if (saiyajin || oozaru) {
				tempoSaiyajin += Time.deltaTime;
				if (tempoSaiyajin >= delayTempoSaiyajin && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigoRapido && !poderInimigoCarrega) {
					saiyajin = false;
					//oozaru = false;
					tempoSaiyajin = 0.0f;
					VoltaNormal ();
				}
			}
		
			if (!transformacao && iniciou && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigoRapido && !poderInimigoCarrega && !acabou && !mostraMensagemFim) {
			
				frequenciaGolpes -= Time.deltaTime;
				if (frequenciaGolpes <= 0) {
					if (delayFrequenciaGolpes < 0.05f && level <= 30) {
						delayFrequenciaGolpes = 0.05f;
					}
					frequenciaGolpes = delayFrequenciaGolpes;
					if (contHits >= minCombo) {
						pontos += contHits;
					}
					contHits = 0;
				
					if (frequenciaPoderesI == Random.Range (1, frequenciaPoderesI + 1) && !descePoder && !transformacaoDesce) {
						//Debug.Log("poder Inimigo");
						SorteiaPoderInimigo ();
					} else {
						transform.Translate (Vector2.right * velocidade * dificuldade * Time.deltaTime * (-1));
						Camera.main.transform.Translate (Vector2.right * velocidade * dificuldade * Time.deltaTime * (-1));
						//healthbarInimigo.transform.Translate(Vector2.right * velocidade * dificuldade * Time.deltaTime * (-1));
					
						animatorInimigo.Play ("golpe" + Random.Range (1, 6));
						if (!muteSom)
							AudioSource.PlayClipAtPoint (soco, transform.position, volumeBatida);
						animatorInimigo.SetTrigger ("parar");
					
						animatorJogador.Play ("apanha" + Random.Range (1, 3));
						animatorJogador.SetTrigger ("parar");
						vidaJogador --;
						MudarVidaJogador ();
					}

				}
			
			}
			if (teleporteInicio && !mostraMensagemFim) {
				TeleporteInicio ();
			}


			//Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved
			//if(Input.touchCount > 0 && !transformacao && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigoRapido && !poderInimigoCarrega && !acabou){
			if (Input.GetButtonDown ("Fire1") && !transformacao && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigoRapido && !poderInimigoCarrega && !acabou && !mostraMensagemFim) {
				float toqueY = Input.mousePosition.y;
				float toqueX = Input.mousePosition.x;
			
			
				//primeiraVez.SetActive(false);
				if (level == 1) {
					primeiraVez.SetActive (false);
				}
				objGoSprite.SetActive (false);
				sr.SetActive (false);
				if (!iniciou) {
					teleporteInicio = true;
					//iniciou = false;
				}
			
				if (descePoder) { //85x63
					//objPoderApareceDesce.
				
					Renderer renderDescePoder = objPoderApareceDesce.GetComponent<Renderer> ();
					float maxX = screenPositionToque.x + renderDescePoder.bounds.size.x * (Screen.width / 85) * 4;//85
					float minX = screenPositionToque.x - renderDescePoder.bounds.size.x * (Screen.width / 85) * 4;
					float maxY = screenPositionToque.y + renderDescePoder.bounds.size.y * (Screen.height / 63) * 4;//63
					float minY = screenPositionToque.y - renderDescePoder.bounds.size.y * (Screen.height / 63) * 4;
				
				
				
				
					if (toqueX <= maxX && toqueX >= minX && toqueY <= maxY && toqueY >= minY) {
						poderAmigo = tipoPoderCarrega;
						if (!muteSom)
							AudioSource.PlayClipAtPoint (poderCarregaCharge, transform.position, volumeBatida);
						animatorJogador.Play ("poder1");
						animatorInimigo.SetTrigger ("parar");
						somKame = true;
						somTeleport = true;
						mudaPosition = true;
						tempoAtaque = 0;
						//Time.timeScale = 0;
						//Handheld.Vibrate();
					
						objPoderApareceDesce.SetActive (false);
						if (contHits >= minCombo) {
							pontos += contHits;
						}
					
						vidaJogador += (vida/10);
						MudarVidaJogador();
						pontos += 20;
						contHits = 0;
						pegouObj = true;
						poderJogadorCarrega = true;
						descePoder = false;
					}
				
				}
			
				if (transformacaoDesce) {//28x35
				
					Renderer renderDesceTrans = objTransformaAparece.GetComponent<Renderer> ();
					float maxX = screenPositionToque.x + renderDesceTrans.bounds.size.x * (Screen.width / 28) * 2;//28
					float minX = screenPositionToque.x - renderDesceTrans.bounds.size.x * (Screen.width / 28) * 2;
					float maxY = screenPositionToque.y + renderDesceTrans.bounds.size.y * (Screen.height / 35) * 2;//35
					float minY = screenPositionToque.y - renderDesceTrans.bounds.size.y * (Screen.height / 35) * 2;
				
				
					if (toqueX <= maxX && toqueX >= minX && toqueY <= maxY && toqueY >= minY) {
					
						objTransformaAparece.SetActive (false);
					
					
						forcaJogador = 1;
						if(nivelTrans == 1 || nivelTrans == 2 || nivelTrans == 3){
							forcaJogador = 2;
						}else if (nivelTrans == 4 || nivelTrans == 5){
							forcaJogador = 3;
						}
						nivel = nivelTrans;
						if (contHits >= minCombo) {
							pontos += contHits;
						}
						//Handheld.Vibrate();
						vidaJogador += (vida/10);
						MudarVidaJogador();
						pontos += 20;
						contHits = 0;
						pegouObj = true;
						transformacao = true;
						transformacaoDesce = false;
					}
				
				
				}
			
			
			
				if (!pegouObj && !transformacao && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigoRapido && !poderInimigoCarrega && iniciou && !acabou) {
				
					transform.Translate (Vector2.right * velocidade * dificuldade * Time.deltaTime);
					Camera.main.transform.Translate (Vector2.right * velocidade * dificuldade * Time.deltaTime);
					//healthbarJogador.transform.Translate(Vector2.right * velocidade * dificuldade * Time.deltaTime * (-1));
					Bater ();
				
				}
			}
			pegouObj = false;

		
			if (transformacao) {
				TransformacaoJogador ();
			}
		
			if (poderJogadorCarrega) {
				SoltaPoderJogadorCarrega ();
			}
		
			if (poderJogadorRapido) {
				SoltaPoderJogadorRapido ();
			}
		
			if (descePoder) {
				DescePoder ();
			}
		
			if (transformacaoDesce) {
				DesceTransformacao ();
			}
		
			if (poderInimigoRapido || poderInimigoCarrega) {
				SoltaPoderInimigo ();
			}
		
			if (animaFinalI) {
				AnimaFinal (inimigo, jogador);
			}
			if (animaFinalJ) {
				AnimaFinal (jogador, inimigo);
			}
		
			if (mostraTextoCombo) {
				MantemTextoCombo ();
			}

			tempoMudaVida -= Time.deltaTime;
		}
		/*if (!isPlay) {
			backButton.SetActive (true);
			againButton.SetActive (true);
		} else {
			backButton.SetActive (false);
			againButton.SetActive (false);
		}*/

		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		//Debug.Log ("Raycast: " + hit.collider.gameObject.tag);
		if (hit.collider != null && Input.GetButtonDown ("Fire1")) {
			Debug.Log("Raycast " + hit.collider.gameObject.tag);
			if (hit.collider.gameObject.tag == "yes") {
				isPlay = true;
				PlayerPrefs.SetString("mostraFrump", "nao");
				frump.SetActive(false);
				Application.OpenURL ("market://details?id=br.com.droidgo.frump");


				//Application.OpenURL("http://play.google.com/store/apps/details?id=br.com.hyperjoy.frump");
			}

			if (hit.collider.gameObject.tag == "never") {
				PlayerPrefs.SetString("mostraFrump", "nao");
				isPlay = true;
				frump.SetActive(false);

			}

			if (hit.collider.gameObject.tag == "notnow") {
				isPlay = true;
				frump.SetActive(false);
			
			}

			if (hit.collider.gameObject.tag == "play") {

				pauseButton.SetActive(true);
				playButton.SetActive(false);
				Time.timeScale = 0;
				isPlay = false;
				//play_pause = play;
				audio.mute = true;
				backButton.SetActive (true);
					//Screen.fullScreen = true;

			}

			if (hit.collider.gameObject.tag == "pause") {

				pauseButton.SetActive(false);
				playButton.SetActive(true);
				Time.timeScale = 1;
				isPlay = true;
				//play_pause = pause;
				audio.mute = false;
				backButton.SetActive (false);
					//Screen.fullScreen = false;
					

			}
			if (hit.collider.gameObject.tag == "volumeMuted") {

				volumeOnButton.SetActive(true);
				volumeMutedButton.SetActive(false);

				PlayerPrefs.SetInt ("mute", 1);
				audio.mute = false;
				muteSom = false;
				
			}
			if (hit.collider.gameObject.tag == "volumeOn") {

				volumeOnButton.SetActive(false);
				volumeMutedButton.SetActive(true);

				PlayerPrefs.SetInt ("mute", 0);
				audio.mute = true;
				muteSom = true;

			}
			if (hit.collider.gameObject.tag == "vibrateOn") {

				vibrateOffButton.SetActive(true);
				vibrateOnButton.SetActive(false);
				//vibrateOnOff = vibrateOff;
				vibrate = false;
				PlayerPrefs.SetInt ("vibrate", 0);

			}

			if (hit.collider.gameObject.tag == "vibrateOff") {

				vibrateOffButton.SetActive(false);
				vibrateOnButton.SetActive(true);
				//vibrateOnOff = vibrateOn;
				vibrate = true;
				PlayerPrefs.SetInt ("vibrate", 1);

			}
			if (hit.collider.gameObject.tag == "exit") {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
				} else {
					Application.Quit ();
				}
			}

			if (hit.collider.gameObject.tag == "back") {
				isPlay = false;
				Time.timeScale = 1;
				//Screen.fullScreen = true;
				if (interstitial.IsLoaded ()) {
					//interstitial.Show();
				}
				bannerView.Hide ();
				bannerView.Destroy ();
				request = new AdRequest.Builder ().Build ();
				bannerView.LoadAd (request);
				bannerView.Hide ();
				Application.LoadLevel ("MenuLevel");
			}

			if (hit.collider.gameObject.tag == "again") {
				mostraMensagemFim = false;
				objImgPontos.SetActive (false);
				pontos = 0;
				sr.SetActive (false);
				bannerView.Hide ();
				bannerView.Destroy ();
				request = new AdRequest.Builder ().Build ();
				bannerView.LoadAd (request);
				bannerView.Hide ();
				backButton.SetActive (false);
				againButton.SetActive (false);
			}
		}



		if (!mostraMensagemFim) {
			textStage.text = "Stage:" + level;
			textPoints.text = "Points:" + pontos;
			textPointsFim.text = "";
			textStageFim.text = "";
			textPointsFimMax.text = "";
			textStageFimMax.text = "";
		} else {

			textStage.text = "";
			textPoints.text = "";
			textPointsFim.text = "Points:" + pontos;
			textStageFim.text = "Stage:" + level;
			textPointsFimMax.text = "Max:" + maxPontosPlayer;
			textStageFimMax.text = "Max:" + maxStagePlayer;
			againButton.SetActive (true);
			backButton.SetActive (true);
		}

		if (mostraTextoCombo) {
			textCombo.text = combo + "Hits!";
		} else {
			textCombo.text = "";
		}
	}
	
	bool mudou = true;

	/*public void HandleAdClosed (object sender, System.EventArgs args)
	{
		print ("HandleAdClosed event received");
	}*/
	
	void TeleporteInicio(){
		
		
		if(somTeleport){
			if(!muteSom)
			AudioSource.PlayClipAtPoint(teleport,transform.position,volumeBatida);
			animatorJogador.Play("someTeleporte");
			animatorInimigo.Play("someTeleporte");
			somTeleport=false;
			mudou = false;
		}
		
		
		teleporteSome -= Time.deltaTime;
		if( teleporteSome <= 0){
			
			if(!mudou){
				if(!muteSom)
				AudioSource.PlayClipAtPoint(teleportReverse,transform.position,volumeBatida);
				animatorJogador.Play("apareceTeleporte");
				animatorInimigo.Play("apareceTeleporte");
				inimigo.transform.Translate (Vector2.right*4f);
				jogador.transform.Translate (Vector2.right*4f);
				mudou = true;
			}
			
			teleporteAparece -= Time.deltaTime;
			if(teleporteAparece <= 0){
				teleporteSome = delayTeleport;
				teleporteAparece = delayTeleport;
				
				somTeleport = true;
				iniciou = true;
				teleporteInicio=false;
				
			}
			
		}
		

		
	}
	
	void ProximoLevel(){
		if (contHits >= minCombo) {
			pontos += contHits;
		}
		contHits = 0;
		inimigo.transform.Translate (Vector2.right*4f*(-1));
		jogador.transform.Translate (Vector2.right*4f*(-1));
		iniciou = false;
		if (transformacaoDesce){
			objTransformaAparece.SetActive (false);
			transformacaoDesce = false;
		}
		if (descePoder) {
			objPoderApareceDesce.SetActive (false);
			descePoder = false;
		}
		
		objHealthBarJ10.SetActive(true);
		objHealthBarJ9.SetActive(false);
		objHealthBarJ8.SetActive(false);
		objHealthBarJ7.SetActive(false);
		objHealthBarJ6.SetActive(false);
		objHealthBarJ5.SetActive(false);
		objHealthBarJ4.SetActive(false);
		objHealthBarJ3.SetActive(false);
		objHealthBarJ2.SetActive(false);
		objHealthBarJ1.SetActive(false);
		objHealthBarJ0.SetActive(false);
		objHealthBarJ10.transform.position = healthbarJogador.transform.position;
		healthbarJogador = objHealthBarJ10;
		
		objHealthBarI10.SetActive(true);
		objHealthBarI9.SetActive(false);
		objHealthBarI8.SetActive(false);
		objHealthBarI7.SetActive(false);
		objHealthBarI6.SetActive(false);
		objHealthBarI5.SetActive(false);
		objHealthBarI4.SetActive(false);
		objHealthBarI3.SetActive(false);
		objHealthBarI2.SetActive(false);
		objHealthBarI1.SetActive(false);
		objHealthBarI0.SetActive(false);
		objHealthBarI10.transform.position = healthbarInimigo.transform.position;
		healthbarInimigo = objHealthBarI10;
		
		ultimoInimigo = inimigo;
		Vector3 posBack = new Vector3 (jogador.transform.position.x, background.transform.position.y,background.transform.position.z);
		background.transform.position = posBack;
		
		vidaJogador = vidaInimigo = vida;
		
		mostraMsg = true;
		//level ++;
		
		SorteiaInimigo ();
		animatorInimigo = inimigo.transform.GetComponent<Animator> ();
	}
	
	void DescePoder(){
		
		objPoderApareceDesce.transform.Translate(Vector2.up * velocidadeDesce * Time.deltaTime  * (-1));
		
		screenPositionToque = Camera.main.WorldToScreenPoint (objPoderApareceDesce.transform.position);
		
		if (screenPositionToque.y < 0) {
			objPoderApareceDesce.SetActive(false);
			descePoder = false;
		}
		
		
	}
	
	void DesceTransformacao(){
		
		objTransformaAparece.transform.Translate(Vector2.up * velocidadeDesce * Time.deltaTime  * (-1));
		
		screenPositionToque = Camera.main.WorldToScreenPoint (objTransformaAparece.transform.position);
		
		if (screenPositionToque.y < 0) {
			objTransformaAparece.SetActive(false);
			transformacaoDesce = false;
		}
	}
	float tempoMostraCombo = 1.0f;
	void MantemTextoCombo(){
		tempoMostraCombo -= Time.deltaTime;
		if (tempoMostraCombo <= 0) {
			mostraTextoCombo = false;
			
		}
		
	}
	//private bool mantemTextoCombo = false;
	void Bater(){
		if(delayFrequenciaGolpes < 0.05f && level <=30){
			delayFrequenciaGolpes = 0.05f;
		}
		frequenciaGolpes = delayFrequenciaGolpes;
		
		sr.SetActive (false);
		
		int poder = Random.Range (1, (int)(frequenciaPoderesJ/forcaJogador) +1);
		if (poder != (int)(frequenciaPoderesJ/forcaJogador) || descePoder || transformacaoDesce) {
			animatorJogador.Play ("golpe" + Random.Range (1, 6));
			if(oozaru){
				if(!muteSom)
				AudioSource.PlayClipAtPoint (socoForte, transform.position, volumeBatida);
				//Handheld.Vibrate();
			}else{
				if(!muteSom)
				AudioSource.PlayClipAtPoint (soco, transform.position, volumeBatida);
			}
			animatorJogador.SetTrigger ("parar");
			
			animatorInimigo.Play ("apanha" + Random.Range (1, 3));
			animatorInimigo.SetTrigger ("parar");
			

			
			
			contHits++;
			if(contHits >= minCombo){
				mostraTextoCombo = true;
				tempoMostraCombo = 1.0f;
				combo = contHits;
			}
			pontos += (int)forcaJogador;
			vidaInimigo -= forcaJogador;
			MudarVidaInimigo ();
			
			
		} else {
			
			int tipo = Random.Range(1,4);
			if(tipo == 1 && !oozaru){
				if(nivel == 0){
					AparecePoder(2);
				}else if (nivel == 1 || nivel == 2 || nivel == 3){
					AparecePoder(1);
				}else if (nivel == 4){
					AparecePoder(3);
				}
				

				
			}else if (tipo == 2 && !saiyajin && !oozaru){
				
				nivelTrans = Random.Range(1,6);
				//nivelTrans = 4;
				ApareceTransforma();
				
			}else if (tipo == 3 && !oozaru){
				if (contHits >= minCombo) {
					pontos += contHits;
				}
				contHits = 0;
				StartCoroutine("somAtaqueRapido");

				if(nivel == 0){
					poderAmigo = objPoderRapido1;
				}else if (nivel == 1 || nivel == 2 || nivel == 3){
					poderAmigo = objPoderRapido2;
				}else if (nivel == 4){
					poderAmigo = objPoderRapidoss4;
				}

				animatorJogador.Play ("poder2");
				animatorInimigo.SetTrigger ("parar");
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				
				poderJogadorRapido = true;
			}else{
				animatorJogador.Play ("golpe" + Random.Range (1, 6));
				if(oozaru){
					if(!muteSom)
					AudioSource.PlayClipAtPoint (socoForte, transform.position, volumeBatida);
				}else{
					if(!muteSom)
					AudioSource.PlayClipAtPoint (soco, transform.position, volumeBatida);
				}
				animatorJogador.SetTrigger ("parar");
				
				animatorInimigo.Play ("apanha" + Random.Range (1, 3));
				animatorInimigo.SetTrigger ("parar");

				contHits ++;
				if(contHits == minCombo){
					mostraTextoCombo = true;
					tempoMostraCombo = 1.0f;
					combo = contHits;
				}
				pontos += (int)forcaJogador;
				vidaInimigo -=forcaJogador;
				MudarVidaInimigo ();
			}
			
		}
		
	}
	private GameObject objSkinJogador;
	void ApareceTransforma(){
		if (vibrate) {
			Handheld.Vibrate ();
		}
		Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(50,Screen.width-50), Screen.height, 2));
		
		objTransformaSS1.transform.position = screenPosition;
		objTransformaSS2.transform.position = screenPosition;
		objTransformaSS3.transform.position = screenPosition;
		objTransformaSS4.transform.position = screenPosition;
		objTransformaMoon.transform.position = screenPosition;
		
		if(nivelTrans == 1){
			
			objTransformaSS1.SetActive(true);
			objTransformaSS2.SetActive(false);
			objTransformaSS3.SetActive(false);
			objTransformaSS4.SetActive(false);
			objTransformaMoon.SetActive(false);
			
			objTransformaAparece = objTransformaSS1;

		}else if (nivelTrans == 2){
			objTransformaSS1.SetActive(false);
			objTransformaSS2.SetActive(true);
			objTransformaSS3.SetActive(false);
			objTransformaSS4.SetActive(false);
			objTransformaMoon.SetActive(false);
			
			objTransformaAparece = objTransformaSS2;
			
			
		}else if (nivelTrans == 3){
			objTransformaSS1.SetActive(false);
			objTransformaSS2.SetActive(false);
			objTransformaSS3.SetActive(true);
			objTransformaSS4.SetActive(false);
			objTransformaMoon.SetActive(false);
			
			objTransformaAparece = objTransformaSS3;
			
			
		}else if (nivelTrans == 4){
			objTransformaSS1.SetActive(false);
			objTransformaSS2.SetActive(false);
			objTransformaSS3.SetActive(false);
			objTransformaSS4.SetActive(true);
			objTransformaMoon.SetActive(false);
			
			objTransformaAparece = objTransformaSS4;
			
			
		}else if (nivelTrans == 5){
			objTransformaSS1.SetActive(false);
			objTransformaSS2.SetActive(false);
			objTransformaSS3.SetActive(false);
			objTransformaSS4.SetActive(false);
			objTransformaMoon.SetActive(true);
			
			objTransformaAparece = objTransformaMoon;
			
			
		}
		
		
		transformacaoDesce=true;
		
	}
	
	void AparecePoder(int tipoPoder){
		if (vibrate) {
			Handheld.Vibrate ();
		}
		Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(50,Screen.width-50), Screen.height, 2));
		
		
		objPoderAparece1.transform.position = screenPosition;
		objPoderAparece2.transform.position = screenPosition;
		objPoderAparecess4.transform.position = screenPosition;
		
		if(tipoPoder == 1){
			objPoderAparece1.SetActive(true);
			objPoderAparecess4.SetActive(false);
			objPoderAparece2.SetActive(false);
			objPoderApareceDesce = objPoderAparece1;
			tipoPoderCarrega = objPoderCarrega1;
			
			
		}else if (tipoPoder == 2){
			objPoderAparece1.SetActive(false);
			objPoderAparecess4.SetActive(false);
			objPoderAparece2.SetActive(true);
			
			objPoderApareceDesce = objPoderAparece2;
			tipoPoderCarrega = objPoderCarrega2; 
			
		}else if (tipoPoder == 3){
			objPoderAparece1.SetActive(false);
			objPoderAparecess4.SetActive(true);
			objPoderAparece2.SetActive(false);
			
			objPoderApareceDesce = objPoderAparecess4;
			tipoPoderCarrega = objPoderCarregass4; 
			
		}
		//
		//
		descePoder=true;
		
		
	}
	
	void VoltaNormal(){
		if (oozaru) {
			jogador.transform.Translate(Vector2.right  * 1f);
			oozaru = false;
			objMostraMoon.SetActive (false);
			
		}
		
		posSkinJogador = objSkinJogador.transform.position;
		objSongokuSkin.SetActive (true);
		objSongokuSS1Skin.SetActive (false);
		objSongokuSS2Skin.SetActive (false);
		objSongokuSS3Skin.SetActive (false);
		objSongokuSS4Skin.SetActive (false);
		objOozaruSkin.SetActive (false);
		objSongokuSkin.transform.position = posSkinJogador;
		objSkinJogador = objSongokuSkin;
		
		
		objSongoku.SetActive (true);
		
		objSongokuss1.SetActive (false);
		objSongokuss2.SetActive (false);
		objSongokuss3.SetActive (false);
		objSongokuss4.SetActive (false);
		objOozaru.SetActive (false);
		objSongoku.transform.position = jogador.transform.position;
		jogador = GameObject.Find (songoku);
		
		animatorJogador = jogador.transform.GetComponent<Animator> ();
		//animatorJogador.transform.Translate(Vector2.right * posicao);
		forcaJogador = 1;
		nivel = 0;
		
	}
	
	
	void ResizeSpriteToScreen() {
		sr.SetActive (true);
		//Renderer render = sr.GetComponent<Renderer> ();
		if (sr == null) return;
		
		sr.transform.localScale = new Vector3(1,1,1);
		
		Vector3 escala = new Vector3 (Screen.width, Screen.height,1.0f);
		
		sr.transform.localScale = escala;
	}
	

	private bool vibrate = true;
	/*void OnGUI()
	{
public GUIStyle fonteChiMenor;
	public GUIStyle fonteChiMedia;
	public GUIStyle fonteChiMaior;
	
	public Texture btnTextureExit; 
	public Texture btnTextureBack; 
	public Texture btnTextureAgain; 

	public Texture vibrateOn; 
	public Texture vibrateOff; 

	public GUIStyle style;

	public Texture play;
	public Texture pause;
	private Texture play_pause;


	private Texture vibrateOnOff;
	private float divideTam = 1f;
		if (false) { // mostraGui
			fonteChiMaior.fontSize = Screen.width / 30;

			fonteChiMedia.fontSize = Screen.width / 40;
			styleStage.fontSize = Screen.width / 20;
			styleStageCombo.fontSize = Screen.width / 10;
		
			if (!mostraMensagemFim) {
				GUI.Label (new Rect ((Screen.width / 10) / 2, (Screen.height / 10) * 2, tamBotao, tamBotao), "Stage:" + level + " / Points:" + pontos, styleStage);
			}
		
			//GUI.TextArea (new Rect((Screen.width/10)*2, (Screen.height/10)*2, tamBotao, tamBotao),"Pontos " + pontos,styleStage);
			if (mostraTextoCombo) {
				GUI.Label (new Rect ((Screen.width / 10) / 2, (Screen.height / 10) * 3, tamBotao, tamBotao), combo + "Hits!", styleStageCombo);
			}
			if (mostraMensagemFim) {
				GUI.Label (new Rect ((Screen.width / 2) + (Screen.width / 40), (Screen.height / 2) - (Screen.height / 4.2f), tamBotao, tamBotao), "Stage:" + level, fonteChiMaior);
				GUI.Label (new Rect ((Screen.width / 2) + (Screen.width / 40), (Screen.height / 2) - (Screen.height / 7f), tamBotao, tamBotao), "Max:" + maxStagePlayer, fonteChiMedia);
				//GUI.TextArea (new Rect ((Screen.width / 2) + (Screen.width/30), (Screen.height / 2)- (Screen.height / 15f), tamBotao, tamBotao),"Max " + maxStagePlayer, fonteChiMenor);
			
				GUI.Label (new Rect ((Screen.width / 2) + (Screen.width / 40), (Screen.height / 2), tamBotao, tamBotao), "Points:" + pontos, fonteChiMaior);
				GUI.Label (new Rect ((Screen.width / 2) + (Screen.width / 40), (Screen.height / 2) + (Screen.height / 10f), tamBotao, tamBotao), "Max:" + maxPontosPlayer, fonteChiMedia);
				//GUI.TextArea (new Rect ((Screen.width / 2) + (Screen.width/30), (Screen.height / 2) + (Screen.height / 5.5f), tamBotao, tamBotao),"Max " + maxPontosPlayer, fonteChiMenor);

				if (GUI.Button (new Rect (20, Screen.height - btnTextureAgain.height / divideTam - 20, btnTextureAgain.width / divideTam, btnTextureAgain.height / divideTam), btnTextureAgain)) {
					mostraMensagemFim = false;
					objImgPontos.SetActive (false);
					pontos = 0;
					sr.SetActive (false);
					bannerView.Hide ();
					bannerView.Destroy ();
					request = new AdRequest.Builder ().Build ();
					bannerView.LoadAd (request);
					bannerView.Hide ();
				}
				if (GUI.Button (new Rect (Screen.width / 2 - btnTextureBack.width / divideTam / 2, Screen.height - (btnTextureExit.height / divideTam * 1.5f) - 20, (btnTextureBack.width / divideTam * 1.5f), (btnTextureBack.height / divideTam * 1.5f)), btnTextureBack)) {
					bannerView.Destroy ();
					isPlay = false;
					Time.timeScale = 1;
					//Screen.fullScreen = true;
					if (interstitial.IsLoaded ()) {
						//interstitial.Show();
					}

					Application.LoadLevel ("MenuLevel");
				}
			
				/*if (GUI.Button (new Rect (Screen.width - btnTextureExit.width/divideTam - 20, Screen.height - btnTextureExit.height/divideTam - 20, btnTextureExit.width/divideTam, btnTextureExit.height/divideTam), btnTextureExit)) {
				if (interstitial.IsLoaded()) {
					interstitial.Show();
				}
				//Application.Quit ();
			}
			
			}

			if (debug) {
				GUI.Label (new Rect ((Screen.width / 10) / 2, (Screen.height / 10) * 4, tamBotao, tamBotao), "Delay Golpes: " + delayFrequenciaGolpes, styleStage);
			}//frequenciaGolpes
			if (GUI.Button (new Rect (Screen.width - (btnTextureExit.width / divideTam * 1.5f) - 20, Screen.height - (btnTextureExit.height / divideTam * 1.5f) - 20, (btnTextureExit.width / divideTam * 1.5f), (btnTextureExit.height / divideTam * 1.5f)), btnTextureExit)) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
				} else {
					Application.Quit ();
				}
				//Application.Quit ();
			}

			if (!isPlay) {
				//exit aqui

				if (GUI.Button (new Rect (Screen.width - ((btnTextureExit.width * 1.5f) * 2) / divideTam - 40, Screen.height - (btnTextureExit.height / divideTam * 1.5f) - 20, (btnTextureBack.width / divideTam * 1.5f), (btnTextureBack.height / divideTam * 1.5f)), btnTextureBack)) {
					isPlay = false;
					Time.timeScale = 1;
					//Screen.fullScreen = true;
					if (interstitial.IsLoaded ()) {
						//interstitial.Show();
					}
					Application.LoadLevel ("MenuLevel");
				}
			}
			if (!mostraMensagemFim) {
				if (GUI.Button (new Rect (Screen.width - (Screen.width / 20) * divideTam - 5, Screen.height / 6, Screen.width / 30 * divideTam, Screen.width / 30 * divideTam), audioMute)) {
					if (!audio.mute) {
						audioMute = mute_on;
						PlayerPrefs.SetInt ("mute", 0);
						audio.mute = true;
						muteSom = true;
					} else {
						audioMute = mute_off;
						PlayerPrefs.SetInt ("mute", 1);
						audio.mute = false;
						muteSom = false;
					}
				}


				if (GUI.Button (new Rect (Screen.width - (Screen.width / 20) * divideTam - 5, Screen.height / 6 + Screen.width / 20 * divideTam + 10, Screen.width / 30 * divideTam, Screen.width / 30 * divideTam), vibrateOnOff)) {
					if (vibrate == true) {
						vibrateOnOff = vibrateOff;
						vibrate = false;

						PlayerPrefs.SetInt ("vibrate", 0);

					} else {
						vibrateOnOff = vibrateOn;
						vibrate = true;
						PlayerPrefs.SetInt ("vibrate", 1);

					}
				}

				if (GUI.Button (new Rect (Screen.width - (Screen.width / 20) * divideTam - 5, Screen.height / 6 + Screen.width / 10 * divideTam + 20, Screen.width / 30 * divideTam, Screen.width / 30 * divideTam), play_pause)) {
					if (isPlay == true) {
						Time.timeScale = 0;
						isPlay = false;
						play_pause = play;
						audio.mute = true;
						//Screen.fullScreen = false;
				
					} else {
						Time.timeScale = 1;
						isPlay = true;
						play_pause = pause;
						audio.mute = false;
						//Screen.fullScreen = true;
					}
				}

			}
			//if (fundoTransparente) {
			//GUI.Box(new Rect(0,0,Screen.width,Screen.height),"",transparentScreen);
			//}
		
			//if(GUI.Button(new Rect(0, 0, tamBotao, tamBotao), "Songoku!") && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigo){
		
			//VoltaNormal();
			//}
			if(GUI.Button(new Rect(Screen.width - tamBotao, 0, tamBotao, tamBotao), imgSongokuss1) && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigo){
			if(!transformacao){
				transformacao=true;
				animatorJogador.Play("transforma");
				AudioSource.PlayClipAtPoint(aura,transform.position,volume);
				forcaJogador = 2;
				nivel = 1;

			}	
		}
		
		if(GUI.Button(new Rect(Screen.width - tamBotao*2, 0, tamBotao, tamBotao),imgSongokuss2 ) && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigo){
			if(!transformacao){
				transformacao=true;
				animatorJogador.Play("transforma");
				AudioSource.PlayClipAtPoint(aura,transform.position,volume);
				forcaJogador = 3;
				nivel = 2;
				
			}	
		}
		
		if(GUI.Button(new Rect(Screen.width - tamBotao*3, 0, tamBotao, tamBotao), imgSongokuss3) && !poderJogadorCarrega && !poderJogadorRapido && !poderInimigo){
			if(!transformacao){
				transformacao=true;
				animatorJogador.Play("transforma");
				AudioSource.PlayClipAtPoint(aura,transform.position,volume);
				forcaJogador = 4;
				nivel = 3;
				
			}	
		}

		}
	} */
	
	
	
	void TransformacaoJogador(){
		
		posSkinJogador = objSkinJogador.transform.position;
		
		if (nivel == 5) {
			tempoTrans += Time.deltaTime;
			objSongokuSkin.SetActive (false);
			objSongokuSS1Skin.SetActive (false);
			objSongokuSS2Skin.SetActive (false);
			objSongokuSS3Skin.SetActive (false);
			objSongokuSS4Skin.SetActive (false);
			objOozaruSkin.SetActive (true);
			objOozaruSkin.transform.position = posSkinJogador;
			objSkinJogador = objOozaruSkin;
			//objSkinJogador.SetActive (false);
			objSongoku.SetActive (false);
			objSongokuss1.SetActive (false);
			objSongokuss2.SetActive (false);
			objSongokuss3.SetActive (false);
			objSongokuss4.SetActive (false);
			objOozaru.SetActive (true);
			objMostraMoon.SetActive (true);
			
			objOozaru.transform.position = jogador.transform.position;
			
			jogador = GameObject.Find (stroozaru);
			
			animatorJogador = jogador.transform.GetComponent<Animator> ();
			animatorJogador.Play ("transforma");
			if(!oozaru){
				jogador.transform.Translate(Vector2.right * (-1) * 1f);
				Vector3 moonPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width*0.8f, Screen.height*0.8f, 14f));
				objMostraMoon.transform.position = moonPosition;
				if(!muteSom)
				AudioSource.PlayClipAtPoint(auraOozaru,transform.position,volume);
				oozaru = true;
			}
			
			
			if (tempoTrans >= delayTrans) {
				transformacao = false;
				tempoTrans = 0;
			}
			
		} else {
			if (!saiyajin) {
				animatorJogador = jogador.transform.GetComponent<Animator> ();
				animatorJogador.Play ("transforma");
				if(!muteSom)
				AudioSource.PlayClipAtPoint (aura, transform.position, volume);
				saiyajin = true;
			}
			
			//StartCoroutine("vib");
			tempoTrans += Time.deltaTime;
			if (tempoTrans >= meiaTransformacao) {
				if (nivel == 1) {
					objSongokuSS1Skin.SetActive (true);
					objSongokuSkin.SetActive (false);
					objSongokuSS2Skin.SetActive (false);
					objSongokuSS3Skin.SetActive (false);
					objSongokuSS4Skin.SetActive (false);
					objOozaruSkin.SetActive (false);
					objSongokuSS1Skin.transform.position = posSkinJogador;
					objSkinJogador = objSongokuSS1Skin;
					
					
					//objSkinJogador.SetActive (false);
					objSongoku.SetActive (false);
					objSongokuss1.SetActive (true);
					objSongokuss2.SetActive (false);
					objSongokuss3.SetActive (false);
					objSongokuss4.SetActive (false);
					objOozaru.SetActive (false);
					objSongokuss1.transform.position = jogador.transform.position;
					jogador = GameObject.Find (songokuss1);
					animatorJogador = jogador.transform.GetComponent<Animator> ();
					animatorJogador.Play ("transforma");
					
				} else if (nivel == 2) {
					objSongokuSkin.SetActive (false);
					objSongokuSS1Skin.SetActive (false);
					objSongokuSS2Skin.SetActive (true);
					objSongokuSS3Skin.SetActive (false);
					objSongokuSS4Skin.SetActive (false);
					objOozaruSkin.SetActive (false);
					objSongokuSS2Skin.transform.position = posSkinJogador;
					objSkinJogador = objSongokuSS2Skin;
					//objSkinJogador.SetActive (false);
					objSongoku.SetActive (false);
					objSongokuss1.SetActive (false);
					objSongokuss2.SetActive (true);
					objSongokuss3.SetActive (false);
					objSongokuss4.SetActive (false);
					objOozaru.SetActive (false);
					objSongokuss2.transform.position = jogador.transform.position;
					jogador = GameObject.Find (songokuss2);
					animatorJogador = jogador.transform.GetComponent<Animator> ();
					animatorJogador.Play ("transforma");
					
				} else if (nivel == 3) {
					objSongokuSkin.SetActive (false);
					objSongokuSS1Skin.SetActive (false);
					objSongokuSS2Skin.SetActive (false);
					objSongokuSS3Skin.SetActive (true);
					objSongokuSS4Skin.SetActive (false);
					objOozaruSkin.SetActive (false);
					objSongokuSS3Skin.transform.position = posSkinJogador;
					objSkinJogador = objSongokuSS3Skin;
					//objSkinJogador.SetActive (false);
					objSongoku.SetActive (false);
					objSongokuss1.SetActive (false);
					objSongokuss2.SetActive (false);
					objSongokuss3.SetActive (true);
					objSongokuss4.SetActive (false);
					objOozaru.SetActive (false);
					objSongokuss3.transform.position = jogador.transform.position;
					jogador = GameObject.Find (songokuss3);
					animatorJogador = jogador.transform.GetComponent<Animator> ();
					animatorJogador.Play ("transforma");
					
				}else if (nivel == 4) {
					objSongokuSkin.SetActive (false);
					objSongokuSS1Skin.SetActive (false);
					objSongokuSS2Skin.SetActive (false);
					objSongokuSS3Skin.SetActive (false);
					objSongokuSS4Skin.SetActive (true);
					objOozaruSkin.SetActive (false);
					objSongokuSS4Skin.transform.position = posSkinJogador;
					objSkinJogador = objSongokuSS4Skin;
					//objSkinJogador.SetActive (false);
					objSongoku.SetActive (false);
					objSongokuss1.SetActive (false);
					objSongokuss2.SetActive (false);
					objSongokuss3.SetActive (false);
					objSongokuss4.SetActive (true);
					objOozaru.SetActive (false);
					objSongokuss4.transform.position = jogador.transform.position;
					jogador = GameObject.Find (songokuss4);
					animatorJogador = jogador.transform.GetComponent<Animator> ();
					animatorJogador.Play ("transforma");
					
				}
				
				if (tempoTrans >= delayTrans) {
					transformacao = false;
					tempoTrans = 0;
				}
				
				
			}
		}
	}
	
	
	void MudarVidaJogador(){
		//healthbarJogador
		
		objHealthBarJ10.SetActive(false);
		objHealthBarJ9.SetActive(false);
		objHealthBarJ8.SetActive(false);
		objHealthBarJ7.SetActive(false);
		objHealthBarJ6.SetActive(false);
		objHealthBarJ5.SetActive(false);
		objHealthBarJ4.SetActive(false);
		objHealthBarJ3.SetActive(false);
		objHealthBarJ2.SetActive(false);
		objHealthBarJ1.SetActive(false);
		objHealthBarJ0.SetActive(false);
		
		if (vidaJogador > (vida/10) * 9) {
			objHealthBarJ10.SetActive(true);
			objHealthBarJ10.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ10;
		}else if (vidaJogador <= (vida/10) * 9 && vidaJogador > (vida/10) * 8) {
			objHealthBarJ9.SetActive(true);
			objHealthBarJ9.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ9;
		}else if (vidaJogador <= (vida/10) * 8 && vidaJogador > (vida/10) * 7) {
			objHealthBarJ8.SetActive(true);
			objHealthBarJ8.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ8;
		}else if (vidaJogador <= (vida/10) * 7 && vidaJogador > (vida/10) * 6) {
			objHealthBarJ7.SetActive(true);
			objHealthBarJ7.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ7;
		}else if (vidaJogador <= (vida/10) * 6 && vidaJogador > (vida/10) * 5) {
			objHealthBarJ6.SetActive(true);
			objHealthBarJ6.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ6;
		}else if (vidaJogador <= (vida/10) * 5 && vidaJogador > (vida/10) * 4) {
			objHealthBarJ5.SetActive(true);
			objHealthBarJ5.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ5;
		}else if (vidaJogador <= (vida/10) * 4 && vidaJogador > (vida/10) * 3) {
			objHealthBarJ4.SetActive(true);
			objHealthBarJ4.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ4;
		}else if (vidaJogador <= (vida/10) * 3 && vidaJogador > (vida/10) * 2) {
			objHealthBarJ3.SetActive(true);
			objHealthBarJ3.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ3;
		}else if (vidaJogador <= (vida/10) * 2 && vidaJogador > (vida/10) * 1) {
			objHealthBarJ2.SetActive(true);
			objHealthBarJ2.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ2;
		}else if (vidaJogador <= (vida/10) * 1 && vidaJogador > 0) {
			objHealthBarJ1.SetActive(true);
			objHealthBarJ1.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ1;
		}else if (vidaJogador <= 0) {
			objHealthBarJ0.SetActive(true);
			objHealthBarJ0.transform.position = healthbarJogador.transform.position;
			healthbarJogador = objHealthBarJ0;
			//animatorInimigo.Play ("golpe1");

			animatorInimigo.SetTrigger ("parar");
			acabou = true;
			animaFinalI = true;
			posSkinInimigo = objSkinInimigo.transform.position;
			if(level > maxStagePlayer){
				PlayerPrefs.SetInt("maxStage",level);
				maxStagePlayer = level;
			}
			if(pontos > maxPontosPlayer){
				PlayerPrefs.SetInt("maxPontos",pontos);
				maxPontosPlayer = pontos;
			}
			
		}
	}

	private float tempoMudaVida = 1f;
	private float delayTempoMudaVida = 1f;
	
	void MudarVidaInimigo(){
		//healthbarJogador
		objHealthBarI10.SetActive(false);
		objHealthBarI9.SetActive(false);
		objHealthBarI8.SetActive(false);
		objHealthBarI7.SetActive(false);
		objHealthBarI6.SetActive(false);
		objHealthBarI5.SetActive(false);
		objHealthBarI4.SetActive(false);
		objHealthBarI3.SetActive(false);
		objHealthBarI2.SetActive(false);
		objHealthBarI1.SetActive(false);
		objHealthBarI0.SetActive(false);
		
		if (vidaInimigo <= vida && vidaInimigo > (vida/10) * 9) {
			objHealthBarI10.SetActive(true);
			objHealthBarI10.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI10;
		}else if (vidaInimigo <= (vida/10) * 9 && vidaInimigo > (vida/10) * 8) {
			objHealthBarI9.SetActive(true);
			objHealthBarI9.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI9;
		}else if (vidaInimigo <= (vida/10) * 8 && vidaInimigo > (vida/10) * 7) {
			objHealthBarI8.SetActive(true);
			objHealthBarI8.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI8;
		}else if (vidaInimigo <= (vida/10) * 7 && vidaInimigo > (vida/10) * 6) {
			objHealthBarI7.SetActive(true);
			objHealthBarI7.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI7;
		}else if (vidaInimigo <= (vida/10) * 6 && vidaInimigo > (vida/10) * 5) {
			objHealthBarI6.SetActive(true);
			objHealthBarI6.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI6;
		}else if (vidaInimigo <= (vida/10) * 5 && vidaInimigo > (vida/10) * 4) {
			objHealthBarI5.SetActive(true);
			objHealthBarI5.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI5;
		}else if (vidaInimigo <= (vida/10) * 4 && vidaInimigo > (vida/10) * 3) {
			objHealthBarI4.SetActive(true);
			objHealthBarI4.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI4;
		}else if (vidaInimigo <= (vida/10) * 3 && vidaInimigo > (vida/10) * 2) {
			objHealthBarI3.SetActive(true);
			objHealthBarI3.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI3;
		}else if (vidaInimigo <= (vida/10) * 2 && vidaInimigo > (vida/10) * 1) {
			objHealthBarI2.SetActive(true);
			objHealthBarI2.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI2;
		}else if (vidaInimigo <= (vida/10) * 1 && vidaInimigo > 0) {
			objHealthBarI1.SetActive(true);
			objHealthBarI1.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI1;
		}else if (vidaInimigo <= 0) {
			objHealthBarI0.SetActive(true);
			objHealthBarI0.transform.position = healthbarInimigo.transform.position;
			healthbarInimigo = objHealthBarI0;
			//animatorJogador.Play ("golpe1");

			int numEsferas = 0;
			if(vidaJogador < 10){
				numEsferas = 0;
			}else if(vidaJogador >= 10 && vidaJogador < 35){
				numEsferas = 1;
			}else if(vidaJogador >= 35 && vidaJogador < 60){
				numEsferas = 2;
			}else if(vidaJogador >= 60 && vidaJogador < 85){
				numEsferas = 3;
			}else if(vidaJogador >=  85){
				numEsferas = 4;
			}

			if(PlayerPrefs.GetInt("numEsferas"+level,0) < numEsferas){
				PlayerPrefs.SetInt("numEsferas"+level, numEsferas);
			}

			if((level+1) > maxStagePlayer){
				PlayerPrefs.SetInt("maxStage",level+1);
				maxStagePlayer = level;
			}
			if(pontos > maxPontosPlayer){
				PlayerPrefs.SetInt("maxPontos",pontos);
				maxPontosPlayer = pontos;
			}

			vidaJogador = vidaInimigo = vida;

			animatorJogador.SetTrigger ("parar");
			acabou = true;
			animaFinalJ = true;
			posSkinInimigo = objSkinInimigo.transform.position;
			
		}
	}
	
	IEnumerator somAtaqueRapido()
	{
		if (!muteSom) {
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
			yield return new WaitForSeconds (.1f);
			AudioSource.PlayClipAtPoint (poderRapido, transform.position, volumeBatida);
		}
		
	}
	
	void AnimaFinal(GameObject vencedor, GameObject perdedor){
		VoltaNormal ();
		firstMatch = false;
		
		if (transformacaoDesce){
			objTransformaAparece.SetActive (false);
			transformacaoDesce = false;
		}
		if (descePoder) {
			objPoderApareceDesce.SetActive (false);
			descePoder = false;
		}
		
		animatorVencedor = vencedor.GetComponent<Animator> ();
		animatorPerdedor  = perdedor.GetComponent<Animator> ();
		
		animatorPerdedor.Play ("morre");
		tempoRodopia -= Time.deltaTime;
		if (tempoRodopia <= 0) {
			tempoCair -= Time.deltaTime;
			if(tempoGolpe == delayGolpe){
				
				animatorVencedor.Play("ultimoGolpe");
				animatorVencedor.SetTrigger("parar");
				posAntesBate = perdedor.transform.position;
			}
			tempoGolpe -= Time.deltaTime;
			if(tempoGolpe <=0){
				if(somBateParede){
					if(!muteSom){
					AudioSource.PlayClipAtPoint (socoForte, transform.position, volumeBatida);
					AudioSource.PlayClipAtPoint (bateParede, transform.position, volumeBatida);
					}
					somBateParede = false;
					animatorPerdedor.SetTrigger("parar");
					
				}
				perdedor.transform.Translate(Vector2.up * 1 * (-1));
			}
			
			
			if(tempoCair <= 0){
				
				if(animaFinalJ){
					if(tempoMudaVida < 0){
						tempoMudaVida = delayTempoMudaVida;
						level ++;

					}
						
					perdedor.transform.position = posAntesBate  ;
					somBateParede = true;
					animaFinalI = animaFinalJ = false;
					tempoRodopia = delayRodopia;
					tempoCair = delayCair;
					tempoGolpe = delayGolpe;
					ProximoLevel();
				}else{
					//vencedor.transform.Translate (Vector2.right*10f*(-1));
					perdedor.transform.position = posAntesBate  ;
					//perdedor.transform.Translate (Vector2.right*4f*(-1));
					somBateParede = true;
					animaFinalI = animaFinalJ = false;
					tempoRodopia = delayRodopia;
					tempoCair = delayCair;
					tempoGolpe = delayGolpe;
					
					mostraMensagemFim = true;
					MostraMenuFim();
					ProximoLevel();
					
				}
				
				
				//}
			}
			
		}
		
	}
	
	private bool mostraMensagemFim = false;
	private GameObject objImgPontos;
	
	void MostraMenuFim(){
		bannerView.Show();

		objImgFinal0.SetActive(true);
		Vector3 posTransform = new Vector3 (Camera.main.transform.position.x,objImgFinal0.transform.position.y, -7f);
		objImgFinal0.SetActive(false);
		
		
		ResizeSpriteToScreen ();
		
		if (maxPontosPlayer < 500) {
			objImgFinal0.SetActive(true);
			objImgFinal0.transform.position = posTransform;
			objImgPontos = objImgFinal0;
		}else if (maxPontosPlayer >= 500 && maxPontosPlayer < 1000) {
			objImgFinal1.SetActive(true);
			objImgFinal1.transform.position = posTransform;
			objImgPontos = objImgFinal1;
		}else if (maxPontosPlayer >= 1000 && maxPontosPlayer < 2000) {
			objImgFinal2.SetActive(true);
			objImgFinal2.transform.position = posTransform;
			objImgPontos = objImgFinal2;
		}else if (maxPontosPlayer >= 2000 && maxPontosPlayer < 3000) {
			objImgFinal3.SetActive(true);
			objImgFinal3.transform.position = posTransform;
			objImgPontos = objImgFinal3;
		}else if (maxPontosPlayer >= 3000 && maxPontosPlayer < 4000) {
			objImgFinal4.SetActive(true);
			objImgFinal4.transform.position = posTransform;
			objImgPontos = objImgFinal4;
		}else if (maxPontosPlayer >= 4000 && maxPontosPlayer < 5000) {
			objImgFinal5.SetActive(true);
			objImgFinal5.transform.position = posTransform;
			objImgPontos = objImgFinal5;
		}else if (maxPontosPlayer >= 5000 && maxPontosPlayer < 6000) {
			objImgFinal6.SetActive(true);
			objImgFinal6.transform.position = posTransform;
			objImgPontos = objImgFinal6;
		}else if (maxPontosPlayer >= 6000) {
			objImgFinalChen.SetActive(true);
			objImgFinalChen.transform.position = posTransform;
			objImgPontos = objImgFinalChen;
		}
		
		//frequenciaPoderesJ = frequenciaPoderesI = frequenciaPoderesInicio;
		//delayFrequenciaGolpes = frequenciaGolpes = frequenciaGolpesInicio;
		
		somBateParede = true;
		animaFinalI = animaFinalJ = false;
		tempoRodopia = delayRodopia;
		tempoCair = delayCair;
		tempoGolpe = delayGolpe;
		//ProximoLevel();
		//level = 1;
		//pontos = 0;
		
	}
	
	IEnumerator somFingerLaser()
	{
		if (!muteSom) {
			AudioSource.PlayClipAtPoint (fingerLaser, transform.position, volumeBatida);
			yield return new WaitForSeconds (1.0f);
			AudioSource.PlayClipAtPoint (fingerLaser, transform.position, volumeBatida);
			yield return new WaitForSeconds (1.0f);
		}
		
		
	}
	GameObject oraditzSkin = null;
	GameObject onappaSkin = null;
	GameObject ogurdSkin = null;
	GameObject ojheeseSkin = null;
	GameObject obuttaSkin = null;
	GameObject obardockSkin = null;
	GameObject oreacoomSkin = null;
	GameObject oginyuSkin = null;
	GameObject oturtlesSkin = null;
	GameObject ofreeza2Skin = null;
	GameObject ofreeza1Skin = null;
	GameObject ocoldSkin = null;
	GameObject ofourthCoolerSkin = null;
	GameObject ofreezaFinalSkin = null;
	GameObject ofreezaCyborgSkin = null;
	GameObject oimperfectCell1Skin = null;
	GameObject ocellJrSkin = null;
	GameObject oimperfectCell2Skin = null;
	GameObject on20Skin = null;
	GameObject on19Skin = null;
	GameObject on16Skin = null;
	GameObject on17Skin = null;
	GameObject on18Skin = null;
	GameObject ometalCoolerSkin = null;
	GameObject ofatBuuSkin = null;
	GameObject osuperBuu1Skin = null;
	GameObject operfectCellSkin = null;
	GameObject ofinalCoolerSkin = null;
	GameObject ochibiBuuSkin = null;
	GameObject osuperBuu3Skin = null;
	GameObject osuperBuu2Skin = null;
	
	private GameObject objSkinInimigo;
	
	Vector3 posSkinInimigo;

	private bool firstMatch = true;
	
	void SorteiaInimigo(){

		requestInterstitial = new AdRequest.Builder().Build();
		interstitial.LoadAd(requestInterstitial);
		
		GameObject objEscolhido;

		//int levelAtual = level;
		if (firstMatch) {
			objBardock = GameObject.Find (bardock);
			objButta = GameObject.Find (butta);
			objChibiBuu = GameObject.Find (chibiBuu);
			objFatBuu = GameObject.Find (fatBuu);
			objSuperBuu1 = GameObject.Find (superBuu1);
			objSuperBuu2 = GameObject.Find (superBuu2);
			objSuperBuu3 = GameObject.Find (superBuu3);
			objCellJr = GameObject.Find (cellJr);
			objImperfectCell1 = GameObject.Find (imperfectCell1);
			objImperfectCell2 = GameObject.Find (imperfectCell2);
			objPerfectCell = GameObject.Find (perfectCell);
			objCold = GameObject.Find (cold);
			objFinalCooler = GameObject.Find (finalCooler);
			objFourthCooler = GameObject.Find (fourthCooler);
			objMetalCooler = GameObject.Find (metalCooler);
			objFreeza1 = GameObject.Find (freeza1);
			objFreeza2 = GameObject.Find (freeza2);
			objFreezaCyborg = GameObject.Find (freezaCyborg);
			objFreezaFinal = GameObject.Find (freezaFinal);
			objGinyu = GameObject.Find (ginyu);
			objGurd = GameObject.Find (gurd);
			objJheese = GameObject.Find (jheese);
			objN16 = GameObject.Find (n16);
			objN17 = GameObject.Find (n17);
			objN18 = GameObject.Find (n18);
			objN19 = GameObject.Find (n19);
			objN20 = GameObject.Find (n20);
			objNappa = GameObject.Find (nappa);
			objRaditz = GameObject.Find (raditz);
			objReacoom = GameObject.Find (reacoom);
			objTurtles = GameObject.Find (turtles);

			oraditzSkin = GameObject.Find (raditzSkin);
			onappaSkin = GameObject.Find (nappaSkin);
			ogurdSkin = GameObject.Find (gurdSkin);
			ojheeseSkin = GameObject.Find (jheeseSkin);
			obuttaSkin = GameObject.Find (buttaSkin);
			obardockSkin = GameObject.Find (bardockSkin);
			oreacoomSkin = GameObject.Find (reacoomSkin);
			oginyuSkin = GameObject.Find (ginyuSkin);
			oturtlesSkin = GameObject.Find (turtlesSkin);
			ofreeza2Skin = GameObject.Find (freeza2Skin);
			ofreeza1Skin = GameObject.Find (freeza1Skin);
			ocoldSkin = GameObject.Find (coldSkin);
			ofourthCoolerSkin = GameObject.Find (fourthCoolerSkin);
			ofreezaFinalSkin = GameObject.Find (freezaFinalSkin);
			ofreezaCyborgSkin = GameObject.Find (freezaCyborgSkin);
			oimperfectCell1Skin = GameObject.Find (imperfectCell1Skin);
			ocellJrSkin = GameObject.Find (cellJrSkin);
			oimperfectCell2Skin = GameObject.Find (imperfectCell2Skin);
			on20Skin = GameObject.Find (n20Skin);
			on19Skin = GameObject.Find (n19Skin);
			on16Skin = GameObject.Find (n16Skin);
			on17Skin = GameObject.Find (n17Skin);
			on18Skin = GameObject.Find (n18Skin);
			ometalCoolerSkin = GameObject.Find (metalCoolerSkin);
			ofatBuuSkin = GameObject.Find (fatBuuSkin);
			osuperBuu1Skin = GameObject.Find (superBuu1Skin);
			operfectCellSkin = GameObject.Find (perfectCellSkin);
			ofinalCoolerSkin = GameObject.Find (finalCoolerSkin);
			ochibiBuuSkin = GameObject.Find (chibiBuuSkin);
			osuperBuu3Skin = GameObject.Find (superBuu3Skin);
			osuperBuu2Skin = GameObject.Find (superBuu2Skin);
		
			 
			ultimoInimigo = objBardock;
			posSkinInimigo = obardockSkin.transform.position;
		}


		oraditzSkin.SetActive (false);
		onappaSkin.SetActive (false);
		ogurdSkin.SetActive (false);
		ojheeseSkin.SetActive (false);
		obuttaSkin.SetActive (false);
		obardockSkin.SetActive (false);
		oreacoomSkin .SetActive (false);
		oginyuSkin.SetActive (false);
		oturtlesSkin.SetActive (false);
		ofreeza2Skin.SetActive (false);
		ofreeza1Skin.SetActive (false);
		ocoldSkin.SetActive (false);
		ofourthCoolerSkin.SetActive (false);
		ofreezaFinalSkin.SetActive (false);
		ofreezaCyborgSkin.SetActive (false);
		oimperfectCell1Skin.SetActive (false);
		ocellJrSkin.SetActive (false);
		oimperfectCell2Skin.SetActive (false);
		on20Skin.SetActive (false);
		on19Skin.SetActive (false);
		on16Skin.SetActive (false);
		on17Skin.SetActive (false);
		on18Skin.SetActive (false);
		ometalCoolerSkin.SetActive (false);
		ofatBuuSkin.SetActive (false);
		osuperBuu1Skin.SetActive (false);
		operfectCellSkin.SetActive (false);
		ofinalCoolerSkin.SetActive (false);
		ochibiBuuSkin.SetActive (false);
		osuperBuu3Skin.SetActive (false);
		osuperBuu2Skin.SetActive (false);

		objBardock.SetActive (false);
		objButta.SetActive (false);
		objChibiBuu.SetActive (false);
		objFatBuu.SetActive (false);
		objSuperBuu1.SetActive (false);
		objSuperBuu2.SetActive (false);
		objSuperBuu3.SetActive (false);
		objCellJr.SetActive (false);
		objImperfectCell1.SetActive (false);
		objImperfectCell2.SetActive (false);
		objPerfectCell.SetActive (false);
		objCold.SetActive (false);
		objFinalCooler.SetActive (false);
		objFourthCooler.SetActive (false);
		objMetalCooler.SetActive (false);
		objFreeza1.SetActive (false);
		objFreeza2.SetActive (false);
		objFreezaCyborg.SetActive (false);
		objFreezaFinal.SetActive (false);
		objGinyu.SetActive (false);
		objGurd.SetActive (false);
		objJheese.SetActive (false);
		objN16.SetActive (false);
		objN17.SetActive (false);
		objN18.SetActive (false);
		objN19.SetActive (false);
		objN20.SetActive (false);
		objNappa.SetActive (false);
		objRaditz.SetActive (false);
		objReacoom.SetActive (false);
		objTurtles.SetActive (false);
	
			
		switch (level)
		{
		case 1: //objBardock
			objBardock.SetActive(true);
			objEscolhido = objBardock;
			//objBardock.transform.position = ultimoInimigo.transform.position;
			inimigoEscolhido = 1;

			obardockSkin.SetActive(true);
			objSkinInimigo = obardockSkin;
			//objSkinInimigo.transform.position = posSkinInimigo;

			frequenciaPoderesJ = 50;
			frequenciaPoderesI = 50;
			delayFrequenciaGolpes = frequenciaGolpes =  0.2f;
			break;
		case 2: //objRaditz
			objRaditz.SetActive(true);
			objEscolhido = objRaditz;
			objRaditz.transform.position = new Vector2(ultimoInimigo.transform.position.x,objRaditz.transform.position.y);
			inimigoEscolhido = 2;
			
			oraditzSkin.SetActive(true);
			objSkinInimigo = oraditzSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 50;
			frequenciaPoderesI = 30;
			delayFrequenciaGolpes = frequenciaGolpes =  0.18f;
			break;
		case 3: //objNappa
			objNappa.SetActive(true);
			objEscolhido = objNappa;
			objNappa.transform.position = new Vector2(ultimoInimigo.transform.position.x,objNappa.transform.position.y);
			inimigoEscolhido = 3;
			
			onappaSkin.SetActive(true);
			objSkinInimigo = onappaSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 50;
			frequenciaPoderesI = 20;
			delayFrequenciaGolpes = frequenciaGolpes =  0.16f;
			break;
		case 4://objGurd
			objGurd.SetActive(true);
			objEscolhido = objGurd;
			objGurd.transform.position = new Vector2(ultimoInimigo.transform.position.x,objGurd.transform.position.y);
			inimigoEscolhido = 4;
			
			ogurdSkin.SetActive(true);
			objSkinInimigo = ogurdSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 50;
			frequenciaPoderesI = 20;
			delayFrequenciaGolpes = frequenciaGolpes =  0.14f;
			break;
		case 5://objReacoom
			objReacoom.SetActive(true);
			objEscolhido = objReacoom;
			objReacoom.transform.position = new Vector2(ultimoInimigo.transform.position.x,objReacoom.transform.position.y);
			inimigoEscolhido = 5;
			
			oreacoomSkin.SetActive(true);
			objSkinInimigo = oreacoomSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 50;
			frequenciaPoderesI = 20;
			delayFrequenciaGolpes = frequenciaGolpes =  0.12f;
			break;
		case 6://objButta
			objButta.SetActive(true);
			objEscolhido = objButta;
			objButta.transform.position = new Vector2(ultimoInimigo.transform.position.x,objButta.transform.position.y);
			inimigoEscolhido = 6;
			
			obuttaSkin.SetActive(true);
			objSkinInimigo = obuttaSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 45;
			frequenciaPoderesI = 20;
			delayFrequenciaGolpes = frequenciaGolpes =  0.1f;
			break;

		case 7://objJheese
			objJheese.SetActive(true);
			objEscolhido = objJheese;
			objJheese.transform.position = new Vector2(ultimoInimigo.transform.position.x,objJheese.transform.position.y);
			inimigoEscolhido = 7;
			
			ojheeseSkin.SetActive(true);
			objSkinInimigo = ojheeseSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 45;
			frequenciaPoderesI = 25;
			delayFrequenciaGolpes = frequenciaGolpes =  0.095f;
			break;
		case 8://objTurtles
			objTurtles.SetActive(true);
			objEscolhido = objTurtles;
			objTurtles.transform.position = new Vector2(ultimoInimigo.transform.position.x,objTurtles.transform.position.y);
			inimigoEscolhido = 8;
			
			oturtlesSkin.SetActive(true);
			objSkinInimigo = oturtlesSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 45;
			frequenciaPoderesI = 25;
			delayFrequenciaGolpes = frequenciaGolpes =  0.09f;
			break;
		case 9://objGinyu
			objGinyu.SetActive(true);
			objEscolhido = objGinyu;
			objGinyu.transform.position = new Vector2(ultimoInimigo.transform.position.x,objGinyu.transform.position.y);
			inimigoEscolhido = 9;
			
			oginyuSkin.SetActive(true);
			objSkinInimigo = oginyuSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 45;
			frequenciaPoderesI = 30;
			delayFrequenciaGolpes = frequenciaGolpes =  0.0875f;
			break;
		case 10://objFreeza1
			objFreeza1.SetActive(true);
			objEscolhido = objFreeza1;
			objFreeza1.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFreeza1.transform.position.y);
			inimigoEscolhido = 10;
			
			ofreeza1Skin.SetActive(true);
			objSkinInimigo = ofreeza1Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 45;
			frequenciaPoderesI = 30;
			delayFrequenciaGolpes = frequenciaGolpes =  0.085f;
			break;
		case 11://objFreeza2
			objFreeza2.SetActive(true);
			objEscolhido = objFreeza2;
			objFreeza2.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFreeza2.transform.position.y);
			inimigoEscolhido = 11;
			
			ofreeza2Skin.SetActive(true);
			objSkinInimigo = ofreeza2Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 40;
			frequenciaPoderesI = 35;
			delayFrequenciaGolpes = frequenciaGolpes =  0.0825f;
			break;
		case 12://objFreezaCyborg
			objFreezaCyborg.SetActive(true);
			objEscolhido = objFreezaCyborg;
			objFreezaCyborg.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFreezaCyborg.transform.position.y);
			inimigoEscolhido = 12;
			
			ofreezaCyborgSkin.SetActive(true);
			objSkinInimigo = ofreezaCyborgSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 40;
			frequenciaPoderesI = 35;
			delayFrequenciaGolpes = frequenciaGolpes =  0.08f;
			break;
		case 13://objFreezaFinal
			objFreezaFinal.SetActive(true);
			objEscolhido = objFreezaFinal;
			objFreezaFinal.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFreezaFinal.transform.position.y);
			inimigoEscolhido = 13;
			
			ofreezaFinalSkin.SetActive(true);
			objSkinInimigo = ofreezaFinalSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 40;
			frequenciaPoderesI = 40;
			delayFrequenciaGolpes = frequenciaGolpes =  0.0775f;
			break;
		case 14://objCold
			objCold.SetActive(true);
			objEscolhido = objCold;
			objCold.transform.position = new Vector2(ultimoInimigo.transform.position.x,objCold.transform.position.y);
			inimigoEscolhido = 14;
			
			ocoldSkin.SetActive(true);
			objSkinInimigo = ocoldSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 40;
			frequenciaPoderesI = 40;
			delayFrequenciaGolpes = frequenciaGolpes =  0.075f;
			break;
		case 15://objN19
			objN19.SetActive(true);
			objEscolhido = objN19;
			objN19.transform.position = new Vector2(ultimoInimigo.transform.position.x,objN19.transform.position.y);
			inimigoEscolhido = 15;
			
			on19Skin.SetActive(true);
			objSkinInimigo = on19Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 40;
			frequenciaPoderesI = 45;
			delayFrequenciaGolpes = frequenciaGolpes =  0.0725f;
			break;
		case 16://objN20
			objN20.SetActive(true);
			objEscolhido = objN20;
			objN20.transform.position = new Vector2(ultimoInimigo.transform.position.x,objN20.transform.position.y);
			inimigoEscolhido = 16;
			
			on20Skin.SetActive(true);
			objSkinInimigo = on20Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 35;
			frequenciaPoderesI = 50;
			delayFrequenciaGolpes = frequenciaGolpes =  0.07f;
			break;
		case 17://objFourthCooler
			objFourthCooler.SetActive(true);
			objEscolhido = objFourthCooler;
			objFourthCooler.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFourthCooler.transform.position.y);
			inimigoEscolhido = 17;
			
			ofourthCoolerSkin.SetActive(true);
			objSkinInimigo = ofourthCoolerSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 35;
			frequenciaPoderesI = 50;
			delayFrequenciaGolpes = frequenciaGolpes =  0.068f;
			break;
		case 18://objMetalCooler
			objMetalCooler.SetActive(true);
			objEscolhido = objMetalCooler;
			objMetalCooler.transform.position = new Vector2(ultimoInimigo.transform.position.x,objMetalCooler.transform.position.y);
			inimigoEscolhido = 18;
			
			ometalCoolerSkin.SetActive(true);
			objSkinInimigo = ometalCoolerSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 35;
			frequenciaPoderesI = 55;
			delayFrequenciaGolpes = frequenciaGolpes =  0.066f;
			break;
		case 19://objFinalCooler
			objFinalCooler.SetActive(true);
			objEscolhido = objFinalCooler;
			objFinalCooler.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFinalCooler.transform.position.y);
			inimigoEscolhido = 19;
			
			ofinalCoolerSkin.SetActive(true);
			objSkinInimigo = ofinalCoolerSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 35;
			frequenciaPoderesI = 55;
			delayFrequenciaGolpes = frequenciaGolpes =  0.064f;
			break;
		case 20://objN16
			objN16.SetActive(true);
			objEscolhido = objN16;
			objN16.transform.position = new Vector2(ultimoInimigo.transform.position.x,objN16.transform.position.y);
			inimigoEscolhido = 20;
			
			on16Skin.SetActive(true);
			objSkinInimigo = on16Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 35;
			frequenciaPoderesI = 60;
			delayFrequenciaGolpes = frequenciaGolpes =  0.062f;
			break;
		case 21://objN17
			objN17.SetActive(true);
			objEscolhido = objN17;
			objN17.transform.position = new Vector2(ultimoInimigo.transform.position.x,objN17.transform.position.y);
			inimigoEscolhido = 21;
			
			on17Skin.SetActive(true);
			objSkinInimigo = on17Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 60;
			delayFrequenciaGolpes = frequenciaGolpes =  0.06f;
			break;
		case 22://objN18
			objN18.SetActive(true);
			objEscolhido = objN18;
			objN18.transform.position = new Vector2(ultimoInimigo.transform.position.x,objN18.transform.position.y);
			inimigoEscolhido = 22;
			
			on18Skin.SetActive(true);
			objSkinInimigo = on18Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 65;
			delayFrequenciaGolpes = frequenciaGolpes =  0.059f;
			break;
		case 23://objCellJr
			objCellJr.SetActive(true);
			objEscolhido = objCellJr;
			objCellJr.transform.position = new Vector2(ultimoInimigo.transform.position.x,objCellJr.transform.position.y);
			inimigoEscolhido = 23;
			
			ocellJrSkin.SetActive(true);
			objSkinInimigo = ocellJrSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 65;
			delayFrequenciaGolpes = frequenciaGolpes =  0.058f;
			break;
		case 24://objImperfectCell1
			objImperfectCell1.SetActive(true);
			objEscolhido = objImperfectCell1;
			objImperfectCell1.transform.position = new Vector2(ultimoInimigo.transform.position.x,objImperfectCell1.transform.position.y);
			inimigoEscolhido = 24;
			
			oimperfectCell1Skin.SetActive(true);
			objSkinInimigo = oimperfectCell1Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 70;
			delayFrequenciaGolpes = frequenciaGolpes =  0.057f;
			break;
		case 25://objImperfectCell2
			objImperfectCell2.SetActive(true);
			objEscolhido = objImperfectCell2;
			objImperfectCell2.transform.position = new Vector2(ultimoInimigo.transform.position.x,objImperfectCell2.transform.position.y);
			inimigoEscolhido = 25;
			
			oimperfectCell2Skin.SetActive(true);
			objSkinInimigo = oimperfectCell2Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 70;
			delayFrequenciaGolpes = frequenciaGolpes =  0.056f;
			break;
		case 26://objPerfectCell
			objPerfectCell.SetActive(true);
			objEscolhido = objPerfectCell;
			objPerfectCell.transform.position = new Vector2(ultimoInimigo.transform.position.x,objPerfectCell.transform.position.y);
			inimigoEscolhido = 26;
			
			operfectCellSkin.SetActive(true);
			objSkinInimigo = operfectCellSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 75;
			delayFrequenciaGolpes = frequenciaGolpes =  0.055f;
			break;
			
		case 27://objFatBuu
			objFatBuu.SetActive(true);
			objEscolhido = objFatBuu;
			objFatBuu.transform.position = new Vector2(ultimoInimigo.transform.position.x,objFatBuu.transform.position.y);
			inimigoEscolhido = 27;
			
			ofatBuuSkin.SetActive(true);
			objSkinInimigo = ofatBuuSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 75;
			delayFrequenciaGolpes = frequenciaGolpes =  0.054f;
			break;
		case 28://objChibiBuu
			objChibiBuu.SetActive(true);
			objEscolhido = objChibiBuu;
			objChibiBuu.transform.position = new Vector2(ultimoInimigo.transform.position.x,objChibiBuu.transform.position.y);
			inimigoEscolhido = 28;
			
			ochibiBuuSkin.SetActive(true);
			objSkinInimigo = ochibiBuuSkin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 80;
			delayFrequenciaGolpes = frequenciaGolpes =  0.053f;
			break;
		case 29://objSuperBuu1
			objSuperBuu1.SetActive(true);
			objEscolhido = objSuperBuu1;
			objSuperBuu1.transform.position = new Vector2(ultimoInimigo.transform.position.x,objSuperBuu1.transform.position.y);
			inimigoEscolhido = 29;
			
			osuperBuu1Skin.SetActive(true);
			objSkinInimigo = osuperBuu1Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 80;
			delayFrequenciaGolpes = frequenciaGolpes =  0.052f;
			break;
		case 30://objSuperBuu2
			objSuperBuu2.SetActive(true);
			objEscolhido = objSuperBuu2;
			objSuperBuu2.transform.position = new Vector2(ultimoInimigo.transform.position.x,objSuperBuu2.transform.position.y);
			inimigoEscolhido = 30;
			
			osuperBuu2Skin.SetActive(true);
			objSkinInimigo = osuperBuu2Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 85;
			delayFrequenciaGolpes = frequenciaGolpes =  0.051f;
			break;
		default://objSuperBuu3
			objSuperBuu3.SetActive(true);
			objEscolhido = objSuperBuu3;
			objSuperBuu3.transform.position = new Vector2(ultimoInimigo.transform.position.x,objSuperBuu3.transform.position.y);
			inimigoEscolhido = 31;
			
			osuperBuu3Skin.SetActive(true);
			objSkinInimigo = osuperBuu3Skin;
			objSkinInimigo.transform.position = posSkinInimigo;
			
			frequenciaPoderesJ = 30;
			frequenciaPoderesI = 85;
			delayFrequenciaGolpes = frequenciaGolpes =  0.05f;
			break;
				
			}
			
		Debug.Log ("delayFrequenciaGolpes" + delayFrequenciaGolpes);
		Debug.Log ("frequenciaPoderesJ" + frequenciaPoderesJ);
		Debug.Log ("frequenciaPoderesI" + frequenciaPoderesI);

		
		inimigo = objEscolhido;
		/*objEscolhido.SetActive (false);
		objSuperBuu2.SetActive (true);
		inimigo = objSuperBuu2;
		inimigoEscolhido = 31; 
		osuperBuu2Skin.SetActive(true);
		objSkinInimigo = osuperBuu2Skin;
		objSkinInimigo.transform.position = posSkinInimigo;*/
		
		objPoder0 = GameObject.Find (poderesI0);
		objPoder1 = GameObject.Find (poderesI1);
		objPoder2 = GameObject.Find (poderesI2);
		objPoder3 = GameObject.Find (poderesI3);
		objPoder4 = GameObject.Find (poderesI4);
		objPoder5 = GameObject.Find (poderesI5);
		objPoder6 = GameObject.Find (poderesI6);
		objPoder6_2 = GameObject.Find (poderesI6_2);
		objPoder7 = GameObject.Find (poderesI7);
		objPoder8 = GameObject.Find (poderesI8);
		objPoder9 = GameObject.Find (poderesI9);
		objPoder9_2 = GameObject.Find (poderesI9_2);
		objPoder10 = GameObject.Find (poderesI10);
		objPoder11 = GameObject.Find (poderesI11);
		objPoder11_2 = GameObject.Find (poderesI11_2);
		objPoder12 = GameObject.Find (poderesI12);
		objPoder13 = GameObject.Find (poderesI13);
		objPoder14 = GameObject.Find (poderesI14);
		objPoder15 = GameObject.Find (poderesI15);
		objPoder18 = GameObject.Find (poderesI18);
		objPoder19 = GameObject.Find (poderesI19);
		
		objPoder0.SetActive (false);
		objPoder1.SetActive (false);
		objPoder2.SetActive (false);
		objPoder3.SetActive (false);
		objPoder4.SetActive (false);
		objPoder5.SetActive (false);
		objPoder6_2.SetActive (false);
		objPoder6.SetActive (false);
		objPoder7.SetActive (false);
		objPoder8.SetActive (false);
		objPoder9.SetActive (false);
		objPoder9_2.SetActive (false);
		objPoder10.SetActive (false);
		objPoder11.SetActive (false);
		objPoder11_2.SetActive (false);
		objPoder12.SetActive (false);
		objPoder13.SetActive (false);
		objPoder14.SetActive (false);
		objPoder15.SetActive (false);
		objPoder18.SetActive (false);
		objPoder19.SetActive (false);
	}
	
	void SoltaPoderJogadorCarrega(){
		
		tempoAtaque += Time.deltaTime;
		
		if(tempoAtaque >= carregaAtaque && tempoAtaque <= delayAtaque){
			animatorInimigo.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
			//healthbarInimigo.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
			
			animatorInimigo.Play("levandoPoder");
			distance += Time.deltaTime;
			poderAmigo.SetActive (true);
			
			//Handheld.Vibrate();
			
			if(somKame){
				somKame = false;
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaFire,transform.position,volumeBatida);
			}
		}
		if(tempoAtaque >= delayAtaque){
			if(somTeleport){
				if(!muteSom)
				AudioSource.PlayClipAtPoint(teleport,transform.position,volumeBatida);
				animatorJogador.Play("someTeleporte");
				somTeleport=false;
			}
			
			poderAmigo.SetActive (false);
			
			teleporteSome -= Time.deltaTime;
			if( teleporteSome <= 0){
				if(mudaPosition){
					if(!muteSom)
					AudioSource.PlayClipAtPoint(teleportReverse,transform.position,volumeBatida);
					animatorJogador.Play("apareceTeleporte");
					
					jogador.transform.Translate(Vector2.right * distance);
					
					healthbarJogador.transform.Translate(Vector2.right * distance);
					healthbarInimigo.transform.Translate(Vector2.right * distance *(-1));
					
					objSkinInimigo.transform.Translate(Vector2.right * distance *(-1));
					objSkinJogador.transform.Translate(Vector2.right * distance );
					
					objPoderCarrega1.transform.Translate(Vector2.right * distance);
					objPoderCarrega2.transform.Translate(Vector2.right * distance);
					objPoderCarregass4.transform.Translate(Vector2.right * distance);
					objPoderRapido1.transform.Translate(Vector2.right * distance);
					objPoderRapido2.transform.Translate(Vector2.right * distance);
					objPoderRapidoss4.transform.Translate(Vector2.right * distance);
					objPoder0.transform.Translate(Vector2.right * distance  *(-1));
					objPoder1.transform.Translate(Vector2.right * distance  *(-1));
					objPoder2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder3.transform.Translate(Vector2.right * distance  *(-1));
					objPoder4.transform.Translate(Vector2.right * distance  *(-1));
					objPoder5.transform.Translate(Vector2.right * distance  *(-1));
					objPoder6.transform.Translate(Vector2.right * distance  *(-1));
					objPoder6_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder7.transform.Translate(Vector2.right * distance  *(-1));
					objPoder8.transform.Translate(Vector2.right * distance  *(-1));
					objPoder9.transform.Translate(Vector2.right * distance  *(-1));
					objPoder9_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder10.transform.Translate(Vector2.right * distance  *(-1));
					objPoder11.transform.Translate(Vector2.right * distance  *(-1));
					objPoder11_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder12.transform.Translate(Vector2.right * distance  *(-1));
					objPoder13.transform.Translate(Vector2.right * distance  *(-1));
					objPoder14.transform.Translate(Vector2.right * distance  *(-1));
					objPoder15.transform.Translate(Vector2.right * distance  *(-1));
					objPoder18.transform.Translate(Vector2.right * distance  *(-1));
					objPoder19.transform.Translate(Vector2.right * distance  *(-1));

					/*objImgFinal0.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal1.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal2.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal3.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal4.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal5.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal6.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinalChen.transform.Translate(Vector2.right * distance  *(-1));*/
					
					
					Camera.main.transform.Translate(Vector2.right * distance);
					
					distance = 0;
					mudaPosition = false;
				}
				
				teleporteAparece -= Time.deltaTime;
				if(teleporteAparece <= 0){
					teleporteSome = delayTeleport;
					teleporteAparece = delayTeleport;
					poderJogadorCarrega = false;
					tempoAtaque = 0;
					somTeleport = true;
					
					mudaPosition = true;
					vidaInimigo -= (vida/10) * forcaJogador;
					pontos += (int)(vida/10) * (int)forcaJogador;
					MudarVidaInimigo();
				}
				
			}
		}
	}
	
	void SoltaPoderJogadorRapido(){
		
		tempoAtaque += Time.deltaTime;
		
		if(tempoAtaque <= delayAtaqueRapido){
			animatorInimigo.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
			//healthbarInimigo.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
			//Handheld.Vibrate();
			animatorInimigo.Play("levandoPoder");
			//Handheld.Vibrate();
			
			distance += Time.deltaTime;
			poderAmigo.SetActive (true);
			poderAtaqueRapido += Time.deltaTime;
			//if(poderAtaqueRapido >= delayPoderAtaqueRapido){
			//	AudioSource.PlayClipAtPoint(poderRapido,transform.position,volumeBatida);
			//	poderAtaqueRapido = delayPoderAtaqueRapido;
			//}
		}
		if(tempoAtaque >= delayAtaqueRapido){
			if(somTeleport){
				if(!muteSom)
				AudioSource.PlayClipAtPoint(teleport,transform.position,volumeBatida);
				animatorJogador.Play("someTeleporte");
				somTeleport=false;
			}
			
			poderAmigo.SetActive (false);
			
			teleporteSome -= Time.deltaTime;
			if( teleporteSome <= 0){
				if(mudaPosition){
					if(!muteSom)
					AudioSource.PlayClipAtPoint(teleportReverse,transform.position,volumeBatida);
					animatorJogador.Play("apareceTeleporte");
					
					jogador.transform.Translate(Vector2.right * distance);
					
					healthbarJogador.transform.Translate(Vector2.right * distance);
					healthbarInimigo.transform.Translate(Vector2.right * distance *(-1));
					
					objSkinInimigo.transform.Translate(Vector2.right * distance *(-1));
					objSkinJogador.transform.Translate(Vector2.right * distance );
					
					objPoderCarrega1.transform.Translate(Vector2.right * distance);
					objPoderCarrega2.transform.Translate(Vector2.right * distance);
					objPoderCarregass4.transform.Translate(Vector2.right * distance);
					objPoderRapido1.transform.Translate(Vector2.right * distance);
					objPoderRapido2.transform.Translate(Vector2.right * distance);
					objPoderRapidoss4.transform.Translate(Vector2.right * distance);
					objPoder0.transform.Translate(Vector2.right * distance  *(-1));
					objPoder1.transform.Translate(Vector2.right * distance  *(-1));
					objPoder2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder3.transform.Translate(Vector2.right * distance  *(-1));
					objPoder4.transform.Translate(Vector2.right * distance  *(-1));
					objPoder5.transform.Translate(Vector2.right * distance  *(-1));
					objPoder6.transform.Translate(Vector2.right * distance  *(-1));
					objPoder6_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder7.transform.Translate(Vector2.right * distance  *(-1));
					objPoder8.transform.Translate(Vector2.right * distance  *(-1));
					objPoder9.transform.Translate(Vector2.right * distance  *(-1));
					objPoder9_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder10.transform.Translate(Vector2.right * distance  *(-1));
					objPoder11.transform.Translate(Vector2.right * distance  *(-1));
					objPoder11_2.transform.Translate(Vector2.right * distance  *(-1));
					objPoder12.transform.Translate(Vector2.right * distance  *(-1));
					objPoder13.transform.Translate(Vector2.right * distance  *(-1));
					objPoder14.transform.Translate(Vector2.right * distance  *(-1));
					objPoder15.transform.Translate(Vector2.right * distance  *(-1));
					objPoder18.transform.Translate(Vector2.right * distance  *(-1));
					objPoder19.transform.Translate(Vector2.right * distance  *(-1));

					/*objImgFinal0.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal1.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal2.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal3.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal4.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal5.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinal6.transform.Translate(Vector2.right * distance  *(-1));
					objImgFinalChen.transform.Translate(Vector2.right * distance  *(-1));*/
					
					
					Camera.main.transform.Translate(Vector2.right * distance);
					
					distance = 0;
					mudaPosition = false;
				}
				
				teleporteAparece -= Time.deltaTime;
				if(teleporteAparece <= 0){
					teleporteSome = delayTeleport;
					teleporteAparece = delayTeleport;
					poderJogadorRapido = false;
					tempoAtaque = 0;
					somTeleport = true;
					
					mudaPosition = true;
					vidaInimigo -= (vida/20)*forcaJogador;
					pontos += (int)(vida/20) * (int)forcaJogador;
					MudarVidaInimigo();
				}
				
			}
		}
	}
	//poderInimigoRapido && poderInimigoCarrega
	
	void SoltaPoderInimigo(){
		
		if (poderInimigoRapido) {
			
			tempoAtaque += Time.deltaTime;
			
			if(tempoAtaque <= delayAtaqueRapido){
				animatorJogador.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
				
				animatorJogador.Play("levandoPoder");
				
				distance += Time.deltaTime;
			}
			if(tempoAtaque > delayAtaqueRapido){
				if(somTeleport){
					if(!muteSom)
					AudioSource.PlayClipAtPoint(teleport,transform.position,volumeBatida);
					animatorInimigo.Play("someTeleporte");
					somTeleport=false;
				}
				
				objPoderInimigoEscolhido.SetActive(false);
				
				teleporteSome -= Time.deltaTime;
				if( teleporteSome <= 0){
					if(mudaPosition){
						if(!muteSom)
						AudioSource.PlayClipAtPoint(teleportReverse,transform.position,volumeBatida);
						animatorInimigo.Play("apareceTeleporte");
						
						inimigo.transform.Translate(Vector2.right * distance);
						
						healthbarJogador.transform.Translate(Vector2.right * distance*(-1));
						healthbarInimigo.transform.Translate(Vector2.right * distance );
						
						objSkinInimigo.transform.Translate(Vector2.right * distance );
						objSkinJogador.transform.Translate(Vector2.right * distance * (-1));
						
						objPoderCarrega1.transform.Translate(Vector2.right * distance*(-1));
						objPoderCarrega2.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapido1.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapido2.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapidoss4.transform.Translate(Vector2.right * distance*(-1));
						objPoderCarregass4.transform.Translate(Vector2.right * distance*(-1));
						objPoder0.transform.Translate(Vector2.right * distance );
						objPoder1.transform.Translate(Vector2.right * distance );
						objPoder2.transform.Translate(Vector2.right * distance );
						objPoder3.transform.Translate(Vector2.right * distance );
						objPoder4.transform.Translate(Vector2.right * distance );
						objPoder5.transform.Translate(Vector2.right * distance );
						objPoder6.transform.Translate(Vector2.right * distance );
						objPoder6_2.transform.Translate(Vector2.right * distance);
						objPoder7.transform.Translate(Vector2.right * distance );
						objPoder8.transform.Translate(Vector2.right * distance );
						objPoder9.transform.Translate(Vector2.right * distance );
						objPoder9_2.transform.Translate(Vector2.right * distance);
						objPoder10.transform.Translate(Vector2.right * distance );
						objPoder11.transform.Translate(Vector2.right * distance );
						objPoder11_2.transform.Translate(Vector2.right * distance );
						objPoder12.transform.Translate(Vector2.right * distance );
						objPoder13.transform.Translate(Vector2.right * distance );
						objPoder14.transform.Translate(Vector2.right * distance );
						objPoder15.transform.Translate(Vector2.right * distance );
						objPoder18.transform.Translate(Vector2.right * distance );
						objPoder19.transform.Translate(Vector2.right * distance );

						/*objImgFinal0.transform.Translate(Vector2.right * distance  );
						objImgFinal1.transform.Translate(Vector2.right * distance  );
						objImgFinal2.transform.Translate(Vector2.right * distance  );
						objImgFinal3.transform.Translate(Vector2.right * distance  );
						objImgFinal4.transform.Translate(Vector2.right * distance  );
						objImgFinal5.transform.Translate(Vector2.right * distance  );
						objImgFinal6.transform.Translate(Vector2.right * distance  );
						objImgFinalChen.transform.Translate(Vector2.right * distance  );*/
						
						
						Camera.main.transform.Translate(Vector2.right * distance*(-1));
						
						distance = 0;
						mudaPosition = false;
					}
					
					teleporteAparece -= Time.deltaTime;
					if(teleporteAparece <= 0){
						teleporteSome = delayTeleport;
						teleporteAparece = delayTeleport;
						poderInimigoRapido = false;
						
						tempoAtaque = 0;
						somTeleport = true;
						
						mudaPosition = true;
						vidaJogador -= (vida/10);
						MudarVidaJogador();
					}
					
				}
				
				
			}
			
			
			//poderInimigoRapido = false;
		} else if(poderInimigoCarrega) {
			
			
			tempoAtaque += Time.deltaTime;
			
			if(tempoAtaque >= carregaAtaque && tempoAtaque <= delayAtaque){
				animatorJogador.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
				//healthbarInimigo.transform.Translate(Vector2.right * velocidade * Time.deltaTime*(-1));
				
				animatorJogador.Play("levandoPoder");
				distance += Time.deltaTime;
				objPoderInimigoEscolhido.SetActive(true);
				
				//Handheld.Vibrate();
				
				if(somKame){
					somKame = false;
					if(!muteSom)
					AudioSource.PlayClipAtPoint(poderCarregaFire,transform.position,volumeBatida);
				}
				if(somAzul){
					somAzul = false;
					if(!muteSom)
					AudioSource.PlayClipAtPoint(azulFire,transform.position,volumeBatida);
				}
				if(somRoxoGrito){
					somRoxoGrito = false;
					if(!muteSom)
					AudioSource.PlayClipAtPoint(roxoGritoFire,transform.position,volumeBatida);
				}
				if(somAura){
					somAura = false;
					if(!muteSom)
					AudioSource.PlayClipAtPoint(auraFire,transform.position,volumeBatida);
				}
				if(somAmarelo){
					somAmarelo = false;
					if(!muteSom)
					AudioSource.PlayClipAtPoint(amareloFire,transform.position,volumeBatida);
				}
			}
			if(tempoAtaque >= delayAtaque){
				if(somTeleport){
					if(!muteSom)
					AudioSource.PlayClipAtPoint(teleport,transform.position,volumeBatida);
					animatorInimigo.Play("someTeleporte");
					somTeleport=false;
				}
				
				objPoderInimigoEscolhido.SetActive(false);
				
				teleporteSome -= Time.deltaTime;
				if( teleporteSome <= 0){
					if(mudaPosition){
						if(!muteSom)
						AudioSource.PlayClipAtPoint(teleportReverse,transform.position,volumeBatida);
						animatorInimigo.Play("apareceTeleporte");
						
						inimigo.transform.Translate(Vector2.right * distance);
						
						healthbarJogador.transform.Translate(Vector2.right * distance*(-1));
						healthbarInimigo.transform.Translate(Vector2.right * distance );
						
						objSkinInimigo.transform.Translate(Vector2.right * distance );
						objSkinJogador.transform.Translate(Vector2.right * distance * (-1));
						
						objPoderCarrega1.transform.Translate(Vector2.right * distance*(-1));
						objPoderCarrega2.transform.Translate(Vector2.right * distance*(-1));
						objPoderCarregass4.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapido1.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapido2.transform.Translate(Vector2.right * distance*(-1));
						objPoderRapidoss4.transform.Translate(Vector2.right * distance*(-1));
						objPoder0.transform.Translate(Vector2.right * distance );
						objPoder1.transform.Translate(Vector2.right * distance );
						objPoder2.transform.Translate(Vector2.right * distance );
						objPoder3.transform.Translate(Vector2.right * distance );
						objPoder4.transform.Translate(Vector2.right * distance );
						objPoder5.transform.Translate(Vector2.right * distance );
						objPoder6.transform.Translate(Vector2.right * distance );
						objPoder6_2.transform.Translate(Vector2.right * distance);
						objPoder7.transform.Translate(Vector2.right * distance );
						objPoder8.transform.Translate(Vector2.right * distance );
						objPoder9.transform.Translate(Vector2.right * distance );
						objPoder9_2.transform.Translate(Vector2.right * distance);
						objPoder10.transform.Translate(Vector2.right * distance );
						objPoder11.transform.Translate(Vector2.right * distance );
						objPoder11_2.transform.Translate(Vector2.right * distance );
						objPoder12.transform.Translate(Vector2.right * distance );
						objPoder13.transform.Translate(Vector2.right * distance );
						objPoder14.transform.Translate(Vector2.right * distance );
						objPoder15.transform.Translate(Vector2.right * distance );
						objPoder18.transform.Translate(Vector2.right * distance );
						objPoder19.transform.Translate(Vector2.right * distance );

						/*objImgFinal0.transform.Translate(Vector2.right * distance  );
						objImgFinal1.transform.Translate(Vector2.right * distance  );
						objImgFinal2.transform.Translate(Vector2.right * distance  );
						objImgFinal3.transform.Translate(Vector2.right * distance  );
						objImgFinal4.transform.Translate(Vector2.right * distance  );
						objImgFinal5.transform.Translate(Vector2.right * distance  );
						objImgFinal6.transform.Translate(Vector2.right * distance  );
						objImgFinalChen.transform.Translate(Vector2.right * distance  );*/
						
						
						Camera.main.transform.Translate(Vector2.right * distance*(-1));
						
						distance = 0;
						mudaPosition = false;
					}
					
					teleporteAparece -= Time.deltaTime;
					if(teleporteAparece <= 0){
						teleporteSome = delayTeleport;
						teleporteAparece = delayTeleport;
						poderInimigoCarrega = false;
						tempoAtaque = 0;
						somTeleport = true;
						
						mudaPosition = true;
						vidaJogador -= (vida/10);
						MudarVidaJogador();
					}
					
				}
			}
			
		}
		
		
	}
	
	void SorteiaPoderInimigo(){
		//objPoderInimigoEscolhido
		int num;
		switch (inimigoEscolhido)
		{
		case 2://raditz
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder14.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder14;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder4.SetActive(true);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(azulCharge,transform.position,volumeBatida);
				objPoderInimigoEscolhido = objPoder4;
				objPoderInimigoEscolhido.SetActive(false);
				
				animatorInimigo.Play ("poder9");
				
				somAzul = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 3://nappa
			
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder14.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder14;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder2;
				
				animatorInimigo.Play ("poder11");
				
				poderInimigoRapido=true;
				if(!muteSom)
				AudioSource.PlayClipAtPoint(somGrito,transform.position,volumeBatida);
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 4://gurd
			
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder15.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder15;
				
				animatorInimigo.Play ("poder6");
				if(!muteSom)
				AudioSource.PlayClipAtPoint(ultrassonGurd,transform.position,volumeBatida);
				
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoRapido=true;
			}
			
			break;
		case 7://jheese
			
			objPoder14.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder14;
			
			animatorInimigo.Play ("poder2");
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			poderInimigoRapido=true;
			
			break;
		case 6://butta
			
			
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder6.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder6;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder4.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder4;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(azulCharge,transform.position,volumeBatida);
				
				animatorInimigo.Play ("poder1");
				somAzul = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			
			break;
		case 1://bardock
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder6.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder6;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder4.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder4;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(azulCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somAzul = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			
			
			
			break;
		case 5://recoome
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder10.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder10;
				objPoderInimigoEscolhido.SetActive(false);
				
				animatorInimigo.Play ("poder10");
				if(!muteSom)
				AudioSource.PlayClipAtPoint(roxoGritoCharge,transform.position,volumeBatida);
				somRoxoGrito = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 9://ginyu
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder8.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder8;
				objPoderInimigoEscolhido.SetActive(false);
				
				animatorInimigo.Play ("poder5");
				if(!muteSom)
				AudioSource.PlayClipAtPoint(auraCharge,transform.position,volumeBatida);
				somAura = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 8://turles 
			num = Random.Range(1,3);
			
			objPoder11.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder11;
			
			animatorInimigo.Play ("poder2");
			
			poderInimigoRapido=true;
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			
			break;
		case 11://freeza2
			num = Random.Range(1,3);
			
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somFingerLaser");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 10://freeza1
			num = Random.Range(1,3);
			
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				
				animatorInimigo.Play ("poder3");
				StartCoroutine("somFingerLaser");
				poderInimigoRapido=true;
				//StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 14://cold
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				
				animatorInimigo.Play ("poder3");
				StartCoroutine("somFingerLaser");
				poderInimigoRapido=true;
				//StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 17://4 cooler
			num = Random.Range(1,3);
			
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 13://freeza final
			num = Random.Range(1,3);
			
			if(num ==1){
				
				objPoder11.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				//StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 12://freeza cyborg
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder6_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder6_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			
			break;
		case 24://imperfect cell 1
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 23://cell junior
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 25://imperfect cell 2
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 16://n20
			
			objPoder14.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder14;
			
			animatorInimigo.Play ("poder2");
			
			poderInimigoRapido=true;
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			break;
		case 15://n19
			objPoder14.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder14;
			
			animatorInimigo.Play ("poder2");
			
			poderInimigoRapido=true;
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			break;
		case 20://n16
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder7.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder7;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(amareloCarrega,transform.position,volumeBatida);
				somAmarelo = true;
				animatorInimigo.Play ("poder7");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 21://n17
			objPoder9.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder9;
			
			animatorInimigo.Play ("poder2");
			
			poderInimigoRapido=true;
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			break;
		case 22://n18
			objPoder9.SetActive(true);
			
			objPoderInimigoEscolhido = objPoder9;
			
			animatorInimigo.Play ("poder2");
			
			poderInimigoRapido=true;
			StartCoroutine("somAtaqueRapido");
			
			somTeleport = true;
			tempoAtaque = 0;
			mudaPosition = true;
			break;
		case 18://metalcooler
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder6_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder6_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 27://fatbuu
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder13.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder13;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder1.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder1;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				somKame = true;
				poderInimigoCarrega=true;
			}
			break;
		case 29://superbuu1
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder13.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder13;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder1.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder1;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				somKame = true;
				poderInimigoCarrega=true;
			}
			break;
		case 26://perfect cell
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 19://finalcooler
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder9.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder9;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder11_2.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder11_2;
				StartCoroutine("somFingerLaser");
				animatorInimigo.Play ("poder3");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}
			break;
		case 28://chibibuu
			num = Random.Range(1,4);
			if(num ==1){
				
				objPoder13.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder13;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				
				mudaPosition = true;
			}else if(num == 2){//poderes_4
				
				objPoder0.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder0;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somKame = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}else{//poderes_4
				
				objPoder1.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder1;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somKame = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 31://supebuu 3
			num = Random.Range(1,4);
			if(num ==1){
				
				objPoder13.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder13;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else if(num == 2){//poderes_4
				
				objPoder0.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder0;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somKame = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}else{//poderes_4
				
				objPoder1.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder1;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somKame = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		case 30://superbuu 2
			num = Random.Range(1,3);
			if(num ==1){
				
				objPoder13.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder13;
				
				animatorInimigo.Play ("poder2");
				
				poderInimigoRapido=true;
				StartCoroutine("somAtaqueRapido");
				
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
			}else{//poderes_4
				
				objPoder1.SetActive(true);
				
				objPoderInimigoEscolhido = objPoder1;
				objPoderInimigoEscolhido.SetActive(false);
				if(!muteSom)
				AudioSource.PlayClipAtPoint(poderCarregaCharge,transform.position,volumeBatida);
				animatorInimigo.Play ("poder1");
				somKame = true;
				somTeleport = true;
				tempoAtaque = 0;
				mudaPosition = true;
				poderInimigoCarrega=true;
			}
			break;
		default:
			
			break;
		}
	}
	
}
