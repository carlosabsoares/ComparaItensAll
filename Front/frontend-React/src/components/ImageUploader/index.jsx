import React, { useEffect, useState } from 'react';
import { useDropzone } from 'react-dropzone';
import { makeStyles } from '@material-ui/core/styles';
import { Button } from '@material-ui/core';
import { PictureAsPdf as PdfIcon } from '@material-ui/icons';

const useStyles = makeStyles((theme) => ({
  button: {
    alignSelf: 'flex-start',
    fontWeight: '700',
    marginTop: '10px',
    width: '100%',
  },
  img: {
    display: 'block',
    width: 'auto',
    height: '100%',
  },
  pdf: {
    display: 'block',
    width: 'auto',
    height: '50%',
  },
  thumbInner: {
    display: 'flex',
    flexDirection: 'column',
    width: 150,
    height: 100,
  },
  thumb: {
    display: 'flex',
    flexDirection: 'column',
  },
  thumbsContainer: {
    display: 'flex',
    flexDirection: 'row',
    flexWrap: 'wrap',
    marginTop: 16,
  },
  center: {
    margin:'auto',
    fontSize: '10px',
    overflow: 'hidden',
  },
  uploader: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
  }
}));

function Dropzone(props) {
  const classes = useStyles();
  const { pdf } = props;
  const [files, setFiles] = useState([]);
  const { getRootProps, getInputProps } = useDropzone({
    accept: pdf ? 'application/pdf' : 'image/*',
    multiple: false,
    noDrag: true,
    onDrop: (acceptedFiles) => {
      const files = acceptedFiles.map((file) =>
        Object.assign(file, {
          preview: URL.createObjectURL(file),
        }),
      );
      setFiles(files);
      if (props.onChange) {
        props.onChange(files);
      }
    },
  });

  const removeFile = (file) => () => {
    const newFiles = [...files];
    newFiles.splice(newFiles.indexOf(file), 1);
    setFiles(newFiles);
  };

  const thumbs = files.map((file) => (
    <div className={classes.thumb} key={file.name}>
      <div className={classes.thumbInner}>
        {pdf ? (
          <>
            <PdfIcon color="secondary" className={classes.pdf} />
            <div className={classes.center}>{file.name}</div>
          </>
        ) : (
          <img src={file.preview} className={classes.img} alt="" />
        )}
      </div>
      <Button
        onClick={removeFile(file)}
        color="secondary"
        variant="outlined"
        className={classes.button}
        component="span"
      >
        Remover
      </Button>
    </div>
  ));

  useEffect(
    () => () => {
      files.forEach((file) => URL.revokeObjectURL(file.preview));
    },
    [files],
  );

  return (
    <div className={classes.uploader}>
      <div {...getRootProps({ className: 'btn-dropzone' })}>
        <input {...getInputProps()} />
        <Button color="primary" variant="outlined" className={classes.button} component="span">
          {props.buttonName}
        </Button>
      </div>
      <aside className={classes.thumbsContainer}>{thumbs}</aside>
    </div>
  );
}

export default Dropzone;
