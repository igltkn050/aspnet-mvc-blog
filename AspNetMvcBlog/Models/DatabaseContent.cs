using static System.Net.WebRequestMethods;

namespace AspNetMvcBlog.Models
{
	public class DatabaseContent
	{
		public List<BlogText> _Blogs { get; set; }
		public List<Catagory> _Catagories { get; set; }
		public DatabaseContent()
		{
			_Blogs = new List<BlogText>()
			{
				new BlogText(){
					Id = 1,
					Title = "Yapay Zeka ve Etik: Sorunlar ve Çözümler", 
					Content = "Günümüzde yapay zeka (YZ) teknolojisi, hayatımızın birçok alanında hızla yaygınlaşmaktadır. Özerk sürüş teknolojileri, tıbbi teşhis ve tedavi, kişisel asistanlar ve daha birçok uygulama yapay zeka algoritmaları tarafından desteklenmektedir. Ancak, yapay zekanın gelişimi ve yaygın kullanımı beraberinde bazı etik ve sorunları getiriyor. Bu blog yazısında, yapay zeka ve etik arasındaki ilişkiyi inceleyerek, ortaya çıkan sorunlara odaklanacağız ve bu sorunları çözmek için neler yapabileceğimizi tartışacağız.\r\n\r\n1. Veri Gizliliği ve Mahremiyet:\r\nYapay zeka uygulamaları, büyük miktarda veri toplama ve analiz etme yeteneğine sahiptir. Bu veriler, kullanıcıların özel bilgilerini içerebilir ve kötü amaçlı kişilerin eline geçtiğinde tehlikeli sonuçlara yol açabilir. Bu nedenle, veri gizliliği ve mahremiyeti, yapay zeka teknolojilerinin geliştirilmesinde ve kullanılmasında ele alınması gereken önemli bir etik meseledir.\r\n\r\n2. Algoritma Yanlılığı ve Adalet:\r\nYapay zeka algoritmaları, eğitim verilerine dayanarak kararlar verirler. Ancak, eğitim verilerindeki yanlılık, yapay zekanın da yanlı sonuçlar üretmesine neden olabilir. Örneğin, yüz tanıma algoritmaları bazı etnik grupları yanlış tanıyabilir veya cezai algoritmalar bazı kişilere haksız yere daha sert cezalar verebilir. Algoritma yanlılığını azaltmak ve adil yapay zeka sistemleri geliştirmek için adımlar atılmalıdır.\r\n\r\n3. İşsizlik ve İş Gücü Dönüşümü:\r\nYapay zeka ve otomasyon teknolojileri, birçok sektörde işleri otomatikleştirme potansiyeline sahiptir. Bu durum, bazı işlerin kaybolmasına ve iş gücü dönüşümünün gerekliliğine yol açabilir. Yapay zekanın ekonomik ve sosyal etkilerini dikkate alarak, iş gücü dönüşümü için uygun politikaların geliştirilmesi önemlidir.\r\n\r\n4. Karar Alma ve Sorumluluk:\r\nYapay zeka uygulamaları, önemli kararlar alabilir ve insanların hayatlarını etkileyebilir. Özerk sürüş teknolojilerinde olduğu gibi, araçların trafik kazalarında karar verme sorumluluğu tartışmalıdır. Bu tür durumlarda, yapay zekanın algoritma temelli kararları kimin sorumlu olduğu konusunda netlik sağlanmalıdır.\r\n\r\n5. İnsanlık ve Yapay Zeka İlişkisi:\r\nYapay zeka teknolojisinin gelişmesi, insanların teknolojiye olan bağımlılığını artırabilir ve sosyal ilişkileri etkileyebilir. Ayrıca, bazı yapay zeka uygulamaları, insan benzeri etkileşimler ve duygusal tepkiler sunarak insanlarla daha kişisel bir ilişki kurmayı amaçlayabilir. Bu bağlamda, insanlık ve yapay zeka arasındaki etik boyutlar üzerine düşünmek önemlidir.", 
					Author = "ChatGPT Reis", 
					CatagoryId=1,
					_CommentsList= new List<Comments>(){
				   new Comments() { CommentId = 1,CommentAuthor = "Süper Mario", CommentContent ="Prenses Yorum!"} ,
				   new Comments() { CommentId = 2,CommentAuthor = "Temel Reis", CommentContent ="Ispanak bir harika" },
				   new Comments() { CommentId = 3,CommentAuthor = "Şirin Baba", CommentContent ="Cok Şirin Yorum"},
				   new Comments() { CommentId = 3,CommentAuthor = "Gargamel", CommentContent ="Şirin kokusu alıyorum!"}
					}, 
					Tag="Teknoloji", 
					imageUrl="~/images/news/f1.jpg" , 
					Proverb = "Yapay zeka, insanın düşünce sınırlarını aşarken, insanlığın bilgelik sınırlarını da sorgulamamızı sağlar.", 
					shortTitle = "Yapay zeka hakkında temel bilgiler",
					shortContent = "Yapay zeka, bilgisayarların insan benzeri zihinsel işlevleri gerçekleştiren teknolojilerini ifade eder. Öğrenme, problem çözme ve karar verme gibi yetenekleri, verileri analiz ederek ve desenleri algılayarak gerçekleştirir. Yapay zeka, makine öğrenmesi ve derin öğrenme gibi alt alanları içerir. Otomasyon, sağlık, taşımacılık, eğitim ve iş dünyası gibi birçok sektörde uygulama potansiyeline sahiptir. Etik ve güvenlik açısından önemli sorunları da beraberinde getirir. Dijital asistanlar, otonom araçlar ve doğal dil işleme gibi günlük yaşamda yaygınlaşan kullanımları bulunur. Yapay zeka, gelecekte teknolojik gelişmelerin odak noktasından biri olarak kabul edilmektedir."},



				new BlogText(){Id = 2, 
					Title = "Bitkilerin Gizemli Dünyası: Canlılar Krallığındaki Sessiz Kahramanlar", 
					Content = "Dünya üzerindeki canlıların çeşitliliği içinde bitkiler, kendine özgü ve gizemli bir dünya sunarlar. Yeşillikleriyle doğanın en önemli yapı taşlarından biri olan bitkiler, pek çok açıdan hayati öneme sahiptir. Bu yazıda, bitkilerin dünyasına mercek tutarak onların yaşamları, önemi ve bize sağladığı faydaları inceleyeceğiz.\r\n\r\n1. Bitkilerin Yaşam Döngüsü ve Çeşitliliği:\r\nBitkilerin yaşam döngüsü, tohumdan büyüyerek yetişkin bitkiye dönüşüm ve üreme aşamalarını içerir. Bitkiler, dünya üzerindeki çeşitlilikleriyle büyüleyici bir manzara sunarlar. Çiçek açan bitkiler, çalılar, ağaçlar, otsu bitkiler ve sarmaşıklar gibi birçok farklı türü vardır. Bu zengin çeşitlilik, bitkilerin hayatta kalabilmek için doğal seçilime nasıl uyum sağladığını gösterir.\r\n\r\n2. Fotosentez ve Atmosferin Düzenlenmesi:\r\nBitkiler, fotosentez yoluyla güneş enerjisini kullanarak karbondioksiti (CO2) ve suyu oksijene ve organik bileşiklere dönüştürürler. Fotosentez sayesinde bitkiler, atmosferdeki CO2 seviyelerini düşürerek gezegenimizin yaşam için uygun sıcaklık ve koşullara sahip olmasına katkıda bulunurlar.\r\n\r\n3. Besin Zinciri ve Ekosistemlerin Dengesi:\r\nBitkiler, besin zincirinin temel halkasını oluştururlar. Bitkiler, fotosentez yoluyla ürettikleri organik bileşikleri diğer canlı organizmalar için besin olarak sunarlar. Bu şekilde, bitkiler, ekosistemlerde besin zincirini başlatır ve ekosistemlerin dengeli bir şekilde işlemesine katkı sağlarlar.\r\n\r\n4. İlaç ve Gıda Kaynağı Olarak Bitkiler:\r\nBitkiler, geleneksel tıpta binlerce yıldır kullanılan doğal ilaçlar ve şifalı bitkilerin kaynağıdır. Modern tıpta da pek çok ilaç bitkisel kökenli maddelerden elde edilir. Ayrıca, besinlerin büyük bir kısmını bitkiler sağlar. Sebzeler, meyveler, tahıllar ve baklagiller gibi temel besin gruplarının çoğu bitkisel kökenlidir.", 
					Author = "ChatGPT Reis", 
					CatagoryId=2,
					_CommentsList= new List<Comments>(){
				   new Comments() { CommentId = 1,CommentAuthor = "Milka İneği", CommentContent ="Cok Güzel Yorum"} ,
				   new Comments() { CommentId = 2,CommentAuthor = "Köy İneği", CommentContent ="Yazınız bir harika" },
				   new Comments() { CommentId = 3,CommentAuthor = "Süt İneği", CommentContent ="Cok Müthiş Yorum"}
				},

					 Tag ="Bitkiler", 
					imageUrl=""  , 
					Proverb = "Bülbülü altın kafese koymuşlar, bitkiler bile hayranlıkla dinlermiş.", 
					shortTitle = "Bitkiler ve Doğanın Sırrı: Hayat Veren Yeşil Dünya", 
					shortContent = "Bitkiler, doğanın en kıymetli hediyesidir. Yeryüzündeki canlıların hayat kaynağı olan bitkiler, fotosentezle güneş enerjisini kullanarak oksijen üretir ve karbondioksiti emer. Onlar, ekosistemin temel taşlarıdır ve diğer canlılar için yaşamsal bir denge oluştururlar.\r\n\r\nBitkiler, insanlığın yaşamını kolaylaştıran değerli materyalleri sağlar; yiyecek, ilaç, inşaat malzemeleri ve daha fazlası. Ayrıca, peyzaj düzenlemeleri ve bahçecilik gibi estetik ve hobi alanlarında da insanların hayatına güzellik katarlar.\r\n\r\nAncak, küresel iklim değişikliği ve habitat tahribatı gibi tehditlerle karşı karşıyadırlar. Bu nedenle, doğayı koruyarak ve sürdürülebilir tarım uygulamalarıyla bitkilerin değerini anlamalıyız. Çünkü bitkiler olmadan, dünya soluk alamaz ve hayat dengesi bozulur."},

				  new BlogText(){Id = 3, 
					  Title = "Şehrin Kalbi: Sokaklarından Kültürüne, Şehirlerin Sırları", 
					  Content = "Şehirler, insanların tarih boyunca yaşamaya başladığı ve uygarlıkların doğduğu yerlerdir. İnsanların bir araya gelerek sosyal, ekonomik ve kültürel faaliyetlerde bulunduğu şehirler, çeşitlilikleri ve zenginlikleriyle dikkat çekerler. Bu yazıda, şehirlerin sokaklarından kültürlerine, mimarisinden insanlarına kadar çeşitli yönlerini keşfederek şehirlerin sırlarını inceleyeceğiz.\r\n\r\n1. Tarihi Sokaklar ve Mirasları:\r\nŞehirlerin tarihi sokakları, geçmişe dair ipuçları taşır. Eski binalar, anıtlar, sokak taşları ve eski meydanlar, şehrin tarihini anlamak için önemli kaynaklardır. Tarihi sokaklar, mimari mirasın korunması ve kültürel kimliğin devamı için değerlidir.\r\n\r\n2. Çeşitlilik ve Kültürel Zenginlik:\r\nŞehirler, farklı kültürlerin bir arada yaşadığı merkezlerdir. Bu çeşitlilik, şehirlerin yemek kültüründen sanata, dil ve geleneklere kadar farklılıklar yaratır. Şehirler, farklı kültürlerin etkileşimine olanak tanır ve böylece toplumsal çeşitlilik ve zenginlik oluşturur.\r\n\r\n3. Şehrin Ritmi ve Hızı:\r\nŞehirler, sürekli hareket halinde olan yerlerdir. İnsanlar, işe gidip gelir, alışveriş yapar, sosyalleşir ve kültürel etkinliklere katılır. Şehrin ritmi, zamanın hızlı akışını simgelerken, her anında farklı bir yaşamın kapısını aralar.\r\n\r\n4. Şehir Planlaması ve Mimarisi:\r\nŞehir planlaması ve mimarisi, bir şehrin karakterini belirleyen önemli unsurlardır. Caddelerin düzeni, binaların mimarisi ve yeşil alanların varlığı, bir şehrin estetik ve fonksiyonel özelliklerini yansıtır. Şehirlerin planlaması, sürdürülebilirlik ve insanların yaşam kalitesi açısından büyük önem taşır.\r\n\r\n5. Şehirdeki Toplumsal ve Ekonomik Dinamikler:\r\nŞehirler, ekonomik ve sosyal faaliyetlerin merkezleridir. Ticaret, endüstri, eğitim ve sağlık gibi birçok alanda şehirlerde yoğun etkinlikler görülür. Şehirler, iş imkanları ve toplumsal olanaklar açısından cazip noktalardır.\r\n\r\n6. Şehir ve Çevre:\r\nŞehirler, doğal çevre ile etkileşim içindedir. Yeşil alanların varlığı, hava kirliliği ve trafik yoğunluğu gibi çevresel faktörler, şehirlerin yaşanabilirliğini etkiler. Şehirlerin sürdürülebilirlik adına çevre dostu politikalar uygulaması önemlidir.\r\n\r\nŞehirler, insanların sosyal, ekonomik ve kültürel yaşamını şekillendiren yaşam alanlarıdır. Sokaklarından kültürel zenginliklerine kadar birçok sırrı barındıran şehirler, insanlık tarihinde önemli bir rol oynamıştır. Günümüzde de şehirler, sosyal etkileşimlerin merkezi ve ilerlemenin motorudur. Şehirlerin değerini anlamak ve gelecek nesiller için yaşanabilir ve sürdürülebilir şehirler oluşturmak, insanlığın ortak sorumluluğudur.", 
					  Author = "ChatGPT Reis", 
					  CatagoryId=3,

					 _CommentsList= new List<Comments>(){
				   new Comments() { CommentId = 1,CommentAuthor = "Mimar Sinan", CommentContent ="Cok iyi yorum olmuş"} ,
				   new Comments() { CommentId = 2,CommentAuthor = "Mimar Kemalettin", CommentContent ="Yazınız fantastik" },
				   new Comments() { CommentId = 3,CommentAuthor = "Furkan Uzel", CommentContent ="Cok Kötü Yorum"}

				},
					  Tag="Şehirler ve Medeniyet", 
					  imageUrl="" , 
					  Proverb = "Şehirler, insanların kalplerine sığan, tarih kokan mücevher sandıklarıdır.", 
					  shortTitle = "Karanlığın Aydınlık Dansı: Işık ve Gölgenin Şehir Hikayeleri", 
					  shortContent = "Şehirler, insanoğlunun çağlar boyunca şekillendirdiği, göz alabildiğince karmaşık ve ilgi çekici yerlerdir. Gündüzleri canlı ve renkli bir sahne, geceleri ise ışıkların dans ettiği büyülü bir mekan olurlar. Sokaklarında her adım, tarihin izlerini taşır ve her köşe başında yeni bir hikaye saklar.\r\n\r\nHer şehir, gizemli bir çekim gücüne sahiptir. Mimari yapıları, sokak lezzetleri, kültürel etkinlikleri ve insanlarıyla özgün bir kimlik sergiler. Şehirler, insanların hayatlarını değiştirir, umut verir ve geleceğe yön verir.\r\n\r\nAncak şehirlerin gölgesinde kalan yönleri de vardır. Kalabalık, trafik ve çevresel sorunlar, modern şehirlerin sorunlarıdır. Ancak bu sorunlarla mücadele ederek, şehirlerdeki potansiyeli ortaya çıkarmak mümkündür.\r\n\r\nBu yazıda, şehirlerin aydınlık ve karanlık yönlerine dair zengin bir hikaye koleksiyonu sunulacaktır. Işık ve gölge, her şehrin iç içe geçmiş hikayelerini anlatır. Keşfedilmeyi bekleyen sokaklar, unutulmaz anılar ve umut dolu gelecek, şehirlerin büyülü dünyasında buluşur."},



			};
			_Catagories = new List<Catagory>()
			{
				new Catagory(){Id = 1, CatagoryName ="Teknoloji"},
				 new Catagory(){Id = 2, CatagoryName ="Bitkiler"},
				  new Catagory(){Id = 3, CatagoryName ="Şehirler ve Medeniyet"}
			};
		}
	}
}
