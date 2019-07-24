export default function Confrences(allconf){
    return `
    
    <h1>Choose a Conference</h1>
    <ul>
        ${allconf.map(conference => {
        return `
            <li>
                <p>${conference.name}</p>
                <img src="${confrence.ImageURL}>
                <input class='select-album__id' type='hidden' value="${conference.conferenceId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };