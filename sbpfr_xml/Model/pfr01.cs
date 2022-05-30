using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace sbpfr_xml.Model
{
	[Serializable()]
	[XmlRoot(ElementName = "Работодатель")]
	public class Работодатель
	{

		[XmlElement(ElementName = "РегНомер")]
		public string РегНомер { get; set; }

		[XmlElement(ElementName = "НаименованиеОрганизации")]
		public string НаименованиеОрганизации { get; set; }

		[XmlElement(ElementName = "ИНН")]
		public int ИНН { get; set; }

		[XmlElement(ElementName = "КПП")]
		public int КПП { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "ФИО")]
	public class ФИО
	{

		[XmlElement(ElementName = "Фамилия")]
		public string Фамилия { get; set; }

		[XmlElement(ElementName = "Имя")]
		public string Имя { get; set; }

		[XmlElement(ElementName = "Отчество")]
		public string Отчество { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "Основание")]
	public class Основание
	{

		[XmlElement(ElementName = "Наименование")]
		public string Наименование { get; set; }

		[XmlElement(ElementName = "Дата")]
		public DateTime Дата { get; set; }

		[XmlElement(ElementName = "Номер")]
		public string Номер { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "Мероприятие")]
	public class Мероприятие
	{

		[XmlElement(ElementName = "UUID")]
		public string UUID { get; set; }

		[XmlElement(ElementName = "Дата")]
		public DateTime Дата { get; set; }

		[XmlElement(ElementName = "Вид")]
		public int Вид { get; set; }

		[XmlElement(ElementName = "Должность")]
		public string Должность { get; set; }

		[XmlElement(ElementName = "ЯвляетсяСовместителем")]
		public int ЯвляетсяСовместителем { get; set; }

		[XmlElement(ElementName = "СтруктурноеПодразделение")]
		public string СтруктурноеПодразделение { get; set; }

		[XmlElement(ElementName = "КодВФпоОКЗ")]
		public DateTime КодВФпоОКЗ { get; set; }

		[XmlElement(ElementName = "Основание")]
		public Основание Основание { get; set; }

		[XmlElement(ElementName = "ОснованиеУвольнения")]
		public ОснованиеУвольнения ОснованиеУвольнения { get; set; }

		[XmlElement(ElementName = "Причина")]
		public string Причина { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "ТрудоваяДеятельность")]
	public class ТрудоваяДеятельность
	{

		[XmlElement(ElementName = "Мероприятие")]
		public Мероприятие Мероприятие { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "ЗЛ")]
	public class ЗЛ
	{

		[XmlElement(ElementName = "ФИО")]
		public ФИО ФИО { get; set; }

		[XmlElement(ElementName = "ДатаРождения")]
		public DateTime ДатаРождения { get; set; }

		[XmlElement(ElementName = "СНИЛС")]
		public string СНИЛС { get; set; }

		[XmlElement(ElementName = "ТрудоваяДеятельность")]
		public ТрудоваяДеятельность ТрудоваяДеятельность { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "ОснованиеУвольнения")]
	public class ОснованиеУвольнения
	{

		[XmlElement(ElementName = "ТипОснованияУвольнения")]
		public string ТипОснованияУвольнения { get; set; }

		[XmlElement(ElementName = "НормативныйДокумент")]
		public string НормативныйДокумент { get; set; }

		[XmlElement(ElementName = "Статья")]
		public int Статья { get; set; }

		[XmlElement(ElementName = "Часть")]
		public int Часть { get; set; }

		[XmlElement(ElementName = "Пункт")]
		public int Пункт { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "Руководитель")]
	public class Руководитель
	{

		[XmlElement(ElementName = "ФИО")]
		public ФИО ФИО { get; set; }

		[XmlElement(ElementName = "Должность")]
		public string Должность { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "СЗВ-ТД")]
	public class СЗВТД
	{

		[XmlElement(ElementName = "Работодатель")]
		public Работодатель Работодатель { get; set; }

		[XmlElement(ElementName = "ЗЛ")]
		public List<ЗЛ> ЗЛ { get; set; }

		[XmlElement(ElementName = "ДатаЗаполнения")]
		public DateTime ДатаЗаполнения { get; set; }

		[XmlElement(ElementName = "Руководитель")]
		public Руководитель Руководитель { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "СлужебнаяИнформация")]
	public class СлужебнаяИнформация
	{

		[XmlElement(ElementName = "GUID")]
		public string GUID { get; set; }

		[XmlElement(ElementName = "ДатаВремя")]
		public DateTime ДатаВремя { get; set; }
	}

	[Serializable()]
	[XmlRoot(ElementName = "ЭДПФР")]
	public class ЭДПФР
	{

		[XmlElement(ElementName = "СЗВ-ТД")]
		public СЗВТД СЗВТД { get; set; }

		[XmlElement(ElementName = "СлужебнаяИнформация")]
		public СлужебнаяИнформация СлужебнаяИнформация { get; set; }

		[XmlAttribute(AttributeName = "xsi")]
		public string Xsi { get; set; }

		[XmlAttribute(AttributeName = "АФ5")]
		public string АФ5 { get; set; }

		[XmlAttribute(AttributeName = "УТ2")]
		public string УТ2 { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


}
