function search() {
    var searchedquery = document.getElementById('search').value;
    if (searchedquery.toLowerCase() == "shop") {
        window.location.href = "/Index/Shop#section";
    }
    else if (searchedquery.toLowerCase() == "about")
    {
        window.location.href = "/Index/About";
    }
    else {
        alert("Page not Found !");
    }
}