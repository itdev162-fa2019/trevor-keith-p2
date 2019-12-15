import React from 'react'
import meme0 from '../images/I Made This.jpg';
import meme1 from '../images/Javascript.png';

function About() {
    return (
        <React.Fragment>
            <h1>About</h1>
            <p>This is the TodoList app v1.0.0. I made it using a React tutorial.</p>
            <p>It helped me understand this stuff better, I think I properly understand how this stuff works now</p>
            <p>States still seem really poorly thought out, like why can I not get this data from anywhere, why do I have to go through like 6 different levels to actually use the data</p>
            <p>Other than that, this seems actually pretty reasonable</p>
            <p>I might need a bit more practice before I have it down completely, but I'm comfortable with it now</p>

            <h1>ENJOY THE MEMES</h1>
            <img src={meme0} style={imageStyle} alt='A dank meme'></img>
            <img src={meme1} style={imageStyle} alt="A javscript meme"></img>

            {
            // This is a totally normal duck
            //          _
            //      .__(.)< (MEOW)
            //       \___)
            //~~~~~~~~~~~~~~~~~~~~~~~~~-->
            }

        </React.Fragment>

    )

}

const imageStyle = {
    maxHeight: '900px'


}

export default About;