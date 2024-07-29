const searchInput = document.getElementById('searchInput');
const userTable = document.getElementById("userTable");
const searchButton = document.getElementById('searchButton');



async function fetchUserData(fetchUrl) {
    try {
        const response = await fetch(fetchUrl);
        if (!response.ok)
            throw new Error("Internal Server error from (ServiceTable.json");
        const userData = await response.json();
        return userData;
    } catch (error) {
        console.log("Internal error: " + error);
    }
}

const tableFullData = (async () => {
    const fullData = await fetchUserData("./serviceTable.json");
    tableGenerator(fullData);
    return fullData;
})();




const tableGenerator = (tableData) => {
        const Newtbody = document.createElement('tbody');
        tableData.forEach((data) => {
            const tr = document.createElement('tr');
            Object.keys(data).forEach((key) => {
                const td = document.createElement('td');
                td.innerHTML = data[key];
                td.scope = "row";
                tr.appendChild(td);
            })
         
            Newtbody.appendChild(tr);
        })
        Newtbody.id = "tbody";
        const OldTbody = document.getElementById("tbody");
        userTable.replaceChild(Newtbody, OldTbody);

}





const searchResults = async (key) => {
    try {
        const tableData =
            (String(key).length == 0)
                ? (await tableFullData) : (await tableFullData)
                    .filter((data) => { return data.Key === key });
        tableGenerator(tableData);
    } catch (error) {
        console.log("Internal error: " + error);
    }
}







searchInput.addEventListener('input', async (e) => {
    await searchResults(e.target.value);
})