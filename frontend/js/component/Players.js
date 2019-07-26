export default function Players(playerlist){
    return `
    <h1>Players</h1>
    <div class='children'>
        ${playerlist.map(players => {
        return `
            <div class='child-by-id'>
            <img src="${players.imageURL}">
            <p>${players.name}</p>
            </div>
        `
        })
    .join("")}
        
    </div>
    `
}