using ElasticLinq;

var db = new ElasticContext(new ElasticConnection(new Uri("http://myserver:9200")));
var p = db.Query<People>().Where(p => p.Tags.Contains("tech") && p.State == "WA");