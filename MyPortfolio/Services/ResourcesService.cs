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
			techIcons["Py"] = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/800px-Python-logo-notext.svg.png";
			techIcons["Js"] = "icons/logo-javascript.svg";
			techIcons["React"] = "icons/react-2.svg";
			techIcons["Unity"] = "icons/unity-69.svg";
			techIcons["OpenGL"] = "icons/opengl.svg";
			techIcons["html"] = "icons/html-1.svg";
			techIcons["css"] = "icons/css-3.svg";
			techIcons["OpenCV"] = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/OpenCV_Logo_with_text_svg_version.svg/800px-OpenCV_Logo_with_text_svg_version.svg.png";
			techIcons["SQL"] = "https://user-images.githubusercontent.com/4249331/52232852-e2c4f780-28bd-11e9-835d-1e3cf3e43888.png";
			techIcons["MySQL"] = "https://e7.pngegg.com/pngimages/747/798/png-clipart-mysql-mysql-thumbnail.png";
			techIcons["GDS"] = "https://seeklogo.com/images/G/google-data-studio-logo-6577854870-seeklogo.com.png";
			techIcons["GCP"] = "https://uxwing.com/wp-content/themes/uxwing/download/brands-and-social-media/google-cloud-icon.png";
			techIcons["AWS"] = "icons/amazon-web-services-2.svg";
			techIcons["Redis"] = "https://cdn.icon-icons.com/icons2/2415/PNG/512/redis_plain_logo_icon_146366.png";
			techIcons["Kafka"] = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Apache_kafka.svg/473px-Apache_kafka.svg.png";
		}

		public String getIconSrc(String name)
		{
			return techIcons[name];
		}

	}
}
