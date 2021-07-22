import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import Typography from '@material-ui/core/Typography';

const useStyles = makeStyles({
  root: {
    maxWidth: 345,
  },
  media: {
    height: 140,
  },
});

export default function ProductCard({ item, onClick }) {
  const classes = useStyles();

  const { description, model, manufecturer } = item;

  return (
    <Card className={classes.root} onClick={onClick}>
      <CardActionArea>
        {/* <CardMedia className={classes.media} image={image} title="Imagem do Produto" /> */}
        <CardContent>
          <Typography gutterBottom variant="h5" component="h2">
            {description}
          </Typography>
          <Typography gutterBottom variant="h6" component="h2">
            {model}
          </Typography>
          <Typography variant="body2" color="textSecondary" component="p">
            {manufecturer.description}
          </Typography>
          {/* <Typography variant="body2" color="textSecondary" component="p">
            {description}
          </Typography> */}
        </CardContent>
      </CardActionArea>
    </Card>
  );
}
