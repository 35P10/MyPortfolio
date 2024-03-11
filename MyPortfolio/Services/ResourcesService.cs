namespace MyPortfolio.Services
{
	public class ResourcesService
	{
		private Dictionary<string, string> techIcons = new Dictionary<string, string>();
		public ResourcesService() {
			techIcons["blazor"] = "icons/blazor.svg";
			techIcons[".NET"] = "icons/dot-net-core-7.svg";
			techIcons["CS"] = "icons/c--4.svg";
			techIcons["CPP"] = "icons/c.svg";
			techIcons["Py"] = "icons/python-5.svg";
			techIcons["Js"] = "icons/logo-javascript.svg";
			techIcons["React"] = "icons/react-svgrepo-com.svg";
			techIcons["Unity"] = "icons/unity-69.svg";
			techIcons["OpenGL"] = "icons/opengl-svgrepo-com.svg";
			techIcons["html"] = "icons/html-1.svg";
			techIcons["css"] = "icons/css-3.svg";
			techIcons["OpenCV"] = "icons/opencv-icon.svg";
			techIcons["SQL"] = "icons/icons8-microsoft-sql-server.svg";
			techIcons["MySQL"] = "icons/mysql-6.svg";
			techIcons["GDS"] = "icons/google-data-studio.svg";
			techIcons["GCP"] = "icons/google-cloud-1.svg";
			techIcons["AWS"] = "icons/amazon-web-services-2.svg";
			techIcons["Redis"] = "icons/redis.svg";
			techIcons["Kafka"] = "icons/kafka.svg";
			techIcons["discord"] = "icons/icons8-discord.svg";
            techIcons["sun"] = "icons/sun.png";
            techIcons["moon"] = "icons/moon.png";
        }

		public String getIconSrc(String name)
		{
			return techIcons[name];
		}

	}
}
