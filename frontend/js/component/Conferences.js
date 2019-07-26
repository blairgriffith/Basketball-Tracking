export default function Conferences(allconf){
    return `
    
    <h1>Choose a Conference</h1>
    <ul class='main-flex'>
        ${allconf.map(conference => {
        return `
            <li>
                <img class='select-conference' src="${conference.imageURL}">
                <p>${conference.name}</p>
                <input class='select-conference__id' type='hidden' value="${conference.conferenceId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };